using System;

namespace OneDriveSync
{
    public class OneDriveException : Exception
    {

    }

    public class OneDriveApi
    {
        private Config cfg;
        private string clientID;
        private string refreshToken;
        private string accessToken;

        private DateTime accessTokenExpiration;

        public OneDriveApi(Config cfg)
        {
            this.cfg = cfg;
            this.clientID = cfg.GetValue("client_id");
        }

        public bool init()
        {
            return true;
        }

        public bool authorise()
        {
            return true;
        }

        public object getDefaultDrive()
        {
            return null;
        }

        public object viewChangesById(string id, string statusToken)
        {
            return null;
        }

        public object viewChangesByPath(string path, string statusToken)
        {
            return null;
        }

        public void downloadById(string id, string saveToPath)
        {}

        public object simpleUpload(string localPath, string remotePath)
        {
            return null;
        }

        public object updateById(string id, object data, string eTag = null)
        {
            return null;
        }

        public void deleteById(string id, string eTag = null)
        {

        }

        public object createByPath(string parentPath, object item)
        {
            return null;
        }

        public object createUploadSession(string path, string eTag = null)
        {
            return null;
        }

        public object uploadFragment(string uploadURL, string filepath, long offset, long offsetSize, long fileSize)
        {
            return null;
        }

        public object requestUploadStatus(string uploadURL)
        {
            return null;
        }

        private void redeemToken(string authCode)
        {

        }

        private void newToken()
        {

        }

        private void acquireToken(string postdate)
        {}

        private void checkAccessTokenExpired()
        {}

        private void addAccessTokenHeader()
        {}

        private object get(string url)
        {
            return null;
        }

        private void del(string url)
        {}

        private void download(string url, string filename)
        {}

        private object patch(string url, string patchData)
        {
            return null;
        }

        private object post(string url, string postData)
        {
            return null;
        }

        private object upload(string filepath, string url)
        {
            return null;
        }

        private object perform(string fileData)
        {
            return null;
        }

        private object perform()
        {
            return null;
        }

        private void checkHttpCode()
        {}

        private void checkHttpCode(object response)
        {}
    }
}