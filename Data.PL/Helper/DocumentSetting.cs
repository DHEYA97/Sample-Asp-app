using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Threading.Tasks;

namespace Data.PL.Helper
{
    public static class DocumentSetting
    {
        public static async Task<string> UploadImageAsync(IFormFile Image, string folderName)
        {

            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\files", folderName);
            var ImageName = $"{Guid.NewGuid()}_{Image.FileName}";
            var Imagepath = Path.Combine(FolderPath, ImageName);
            using var stream = new FileStream(Imagepath, FileMode.Create);
            await Image.CopyToAsync(stream);
            stream.Dispose();
            return ImageName;
        }
        public static bool ExistFile(string ImagePath, string folderName)
        {
            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\files", folderName, ImagePath);
            return File.Exists(FolderPath);
        }
        public static void DeleteFile(string ImagePath, string folderName)
        {
            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\files", folderName, ImagePath);
            if(File.Exists(FolderPath))
            {
                File.Delete(FolderPath);
            }
        }
    }
}
