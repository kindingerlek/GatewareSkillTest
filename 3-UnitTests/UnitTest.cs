using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_CopyImagesToDynamicDir;
using System.IO;

namespace _3_UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void WHEN_FolderNotExits_SHOULD_CreateNewFolder()
        {
            var destination = @"C:\ImageFolder\";


            bool folderExistsPreviously = Directory.Exists(destination);       
            ImageCopyTool.CreateFolder(destination);
            bool folderExistsAfter = Directory.Exists(destination);


            Assert.IsFalse(folderExistsPreviously);
            Assert.IsTrue(folderExistsAfter);
        }
        
        [TestMethod]
        public void WHEN_CopyFilesIsCall_SHOULD_CopyFilesToFolder()
        {
            var destination = @"C:\ImageFolder\";
            var path = @"data\";


            var imagesInDestinationBefore = ImageCopyTool.GetImageFilesFrom(destination).Length;
            ImageCopyTool.RunCopy(destination, path);
            var imagesInDestionationAfter = ImageCopyTool.GetImageFilesFrom(destination).Length;
            Directory.Delete(destination, true);

            Assert.AreNotEqual(imagesInDestinationBefore, imagesInDestionationAfter);
        }
    }
}
