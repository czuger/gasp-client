using System;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;

public class BackgroundPlayer
{
    WaveOutEvent outputDevice = null;
    AudioFileReader audioFile = null;
    FadeInOutSampleProvider fader = null;
    public bool interrupt_play = false;
    private bool playback_cleanup_finished = false;
    Array files_list = null;
    string path = null;
    int fade_in_time = 5000;
    int fade_out_time = 2000;

    public BackgroundPlayer( string _path, Array _files_list )
	{
        // Déclaration du thread
        Thread myThread;
        files_list = _files_list;
        path = _path;

        // Instanciation du thread, on spécifie dans le 
        // délégué ThreadStart le nom de la méthode qui
        // sera exécutée lorsque l'on appele la méthode
        // Start() de notre thread.
        myThread = new Thread(new ThreadStart(ThreadLoop));

        // Lancement du thread
        myThread.Start();
    }

    public void play_music()
    {
        foreach (string fileName in files_list)
        {
            audioFile = new AudioFileReader(@path + fileName);
            fader = new FadeInOutSampleProvider(audioFile, true);
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;
            outputDevice.Init(fader);
            fader.BeginFadeIn(fade_in_time);
            outputDevice.Play();
            while (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(500);
                if (interrupt_play)
                {
                    fader.BeginFadeOut(fade_out_time);
                    Thread.Sleep(fade_out_time);
                    outputDevice.Stop();
                    return;
                }
            }
        }
    }

    // C'est ici qu'il faudra faire notre travail.
    public void ThreadLoop()
    {
        // Tant que le thread n'est pas tué, on travaille
        while (Thread.CurrentThread.IsAlive && !interrupt_play)
        {
            play_music();
        }

        while (outputDevice.PlaybackState == PlaybackState.Playing && !playback_cleanup_finished)
        {
            Thread.Sleep(500);
        }
    }

    private void OnPlaybackStopped(object sender, StoppedEventArgs args)
    {
        outputDevice.Dispose();
        outputDevice = null;
        audioFile.Dispose();
        audioFile = null;
        playback_cleanup_finished = true;
    }

}
