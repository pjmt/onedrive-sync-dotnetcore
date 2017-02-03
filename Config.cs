using System;
using System.Collections.Generic;
using System.IO;

namespace OneDriveSync
{
    public class Config
    {
        public string RefreshTokenFilePath { get; set; }
        public string StatusTokenFilePath { get; set; }
        public string DatabaseFilePath { get; set; }
        public string UploadStateFilePath { get; set; }

        private string userConfigFilePath;

        private Dictionary<string,string> values;

        public Config(string configurationFolderName)
        {
            RefreshTokenFilePath = Path.Combine(configurationFolderName, "/refresh_token");
            StatusTokenFilePath = Path.Combine(configurationFolderName, "/status_token");
            DatabaseFilePath = Path.Combine(configurationFolderName, "/items.sqlite3");
            UploadStateFilePath = Path.Combine(configurationFolderName, "/resume_upload");
            userConfigFilePath = Path.Combine(configurationFolderName, "/config");

            values = new Dictionary<string,string>(); 
        }

        public void Init()
        {
            var found = false;

            found |= Load("/etc/onedrive.conf");
            found |= Load("/usr/local/etc/onedrive.conf");
            found |= Load(userConfigFilePath);

            if (!found)
                throw new Exception("No config file found.");
        }

        public string GetValue(string key)
        {
            if (values.ContainsKey(key))
                return values[key];
            else
                throw new KeyNotFoundException();
        }

        public string GetValue(string key, string value)
        {
            if (values.ContainsKey(key))
                return values[key];
            else
                return value;
        }

        private bool Load(string filename)
        {
            try 
            {
                var file = File.OpenText(filename);

                while (!file.EndOfStream)
                {
                    var lineItems = file.ReadLine().Split('=');

                    if (lineItems.Length == 2)
                        values[lineItems[0].Trim()] = lineItems[1].Trim();
                }

                file.Dispose();
            } 
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}