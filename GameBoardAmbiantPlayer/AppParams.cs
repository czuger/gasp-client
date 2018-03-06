using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace GameBoardAmbiantPlayer
{
    class AppParams
    {
        public string guid;
        public string[] folders;
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
            }
        }

        public void SetFolders( string path_name )
        {
            string[] folders = Directory.GetDirectories(path_name, "*", System.IO.SearchOption.AllDirectories);
            this.folders = folders;
            Save();
        }

        private void Save()
        {
            File.WriteAllText(params_filename, JsonConvert.SerializeObject(this));
        }

    }
}
