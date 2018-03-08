using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GameBoardAmbiantPlayer
{
    class AppParams
    {
        public string guid;
        public IEnumerable<string> folders;
        public string email;
        public string path;
        private const string params_filename = "params.json";       

        public void ReadOrCreateParams()
        {
            if ( !File.Exists( params_filename ) )
            {
                guid = Guid.NewGuid().ToString();
                Save();
            }
            else
            {
                AppParams tmp_param;
                string text = File.ReadAllText(params_filename);
                tmp_param = JsonConvert.DeserializeObject<AppParams>(text);
                guid = tmp_param.guid;
                folders = tmp_param.folders;
                email = tmp_param.email;
                path = tmp_param.path;
            }
        }

        public string SetFolders( string path_name )
        {
            path = path_name;
            folders = Directory.EnumerateDirectories(path_name);
            folders = folders.Select(folder => Path.GetFileName(folder));
            return Save();
        }

        public string SetEmail(string _email)
        {
            email = _email;
            return Save();
        }

        private string Save()
        {
            string json_object = JsonConvert.SerializeObject(this);
            Debug.WriteLine(json_object);
            File.WriteAllText(params_filename, json_object);

            ServerCommunication sc = new ServerCommunication();
            return sc.SendData(json_object);
        }
    }
}
