using System;

namespace OneDriveSync
{
    public class SyncException : Exception
    {}

    public class SyncEngine
    {
        private Config cfg;
        private OneDriveApi onedrive;
        private UploadSession session;
        private string statusToken;
        private string[] skippedItems;
        private string[] idsToDelete;

        public SyncEngine(Config cfg, OneDriveApi onedrive)
        {
            this.cfg = cfg;
            this.onedrive = onedrive;

            session = new UploadSession(onedrive, cfg.UploadStateFilePath);
        }

        public void init()
        {

        }

        void applyDifferences()
        {}

        private void applyDifference(object item)
        {

        }

        private void applyNewItem(Item item, string path)
        {}

        private void applyChangedItem(Item oldItem, Item newItem, string newPath)
        {}

        private bool isItemSynced(Item item, string path)
        {
            return false;
        }

        private void deleteItems()
        {}

        public void scanForDifferences(string path)
        {}

        private void uploadDifferences(Item item)
        {}

        private void uploadDirDifferences(Item item, string path)
        {}

        private void uploadFileDifferences(Item item, string path)
        {}

        private void uploadNewItems(string path)
        {}

        private void uploadCreateDir(string path)
        {}

        private void uploadNewFile(string path)
        {}

        private void uploadDeleteItem(Item item, string path)
        {}

        private void uploadLastModifiedTime(string id, string eTag, DateTime mtime)
        {}

        private void SaveItem(object jsonItem)
        {}

        private void uploadMoveItem(string from, string to)
        {}

        private void deleteByPath(string path)
        {}
    }
}