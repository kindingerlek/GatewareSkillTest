using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3_CopyImagesToDynamicDir
{
    public static class ImageCopyTool
    {
        public static void RunCopy(string destination, string path)
        {
            var filesPath = GetImageFilesFrom(path);

            CreateFolder(destination);
            CopyFiles(filesPath, destination);
        }

        private static string[] GetImageTypes()
        {
            return new string[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
        }

        private static void CopyFiles(string[] filesPath, string destination)
        {
            foreach (var filepath in filesPath)
            {
                var file = filepath.ToString();
                var fileName = filepath.Split(@"\").Last();

                if (!File.Exists(destination))
                    File.Copy(file, destination + fileName);
            }
        }

        public static void CreateFolder(string destination)
        {
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);
        }

        public static string[] GetImageFilesFrom(string searchFolder)
        {
            List<string> filesFound = new List<string>();

            foreach (var filter in GetImageTypes())
                filesFound.AddRange(Directory.GetFiles(searchFolder, string.Format("*.{0}", filter)));

            return filesFound.ToArray();
        }
    }
}
