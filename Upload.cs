using System;

using Newtonsoft.Json;

namespace OneDriveSync
{
    public class UploadSession
    {
        private const long fragmentSize = 10 * 2^20; // 10 MiB    

        private OneDriveApi onedrive;
        private bool verbose;
        private object session;
        private string sessionFilePath;

        public UploadSession(OneDriveApi onedrive, string sessionFilePath)
        {
            this.onedrive = onedrive;
            this.sessionFilePath = sessionFilePath;
        }

        public object Upload(string localPath, string remotePath, string eTag)
        {
            return null;
        }

        public bool restore()
        {
            return false;
        }

        private object upload()
        {
            return null;
        }

        private void save()
        {}
    }
}