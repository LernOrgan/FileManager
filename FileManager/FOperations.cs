using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Compression;

namespace FileManager
{
    static internal class FOperations
    {
        public static string[] Discs =
            (from disc in DriveInfo.GetDrives()
            select disc.Name).ToArray();
        public static string? NowDirectoryWay;

        public static string[]? GoForward(string path)
        {
            if (path == "C:\\" || path == "D:\\")
            {  
                return GoToFile(path);
            }
            else
            {
                NowDirectoryWay += "\\" + path;
                return GoToFile(NowDirectoryWay);
            }
        }
        public static string[]? GoToFile(string path) // Возвращает массив из полных имён файлов, содержащихся в данной папке
        {    

            if (File.Exists(path))
            {
                StartFile(path);
                NowDirectoryWay = Path.GetDirectoryName(path);
                return null;
            }
            
            DirectoryInfo Directory = new DirectoryInfo(path);
            DirectoryInfo[] objects1 = Directory.GetDirectories();
            FileInfo[] objects2 = Directory.GetFiles();
            string[] Files =
                        (
                        from file in objects2
                        where !file.Attributes.HasFlag(FileAttributes.Hidden)
                        select file.Name
                         )
                         .Union
                         (
                            from file in objects1
                            where !file.Attributes.HasFlag(FileAttributes.Hidden)
                            select file.Name).ToArray();
            NowDirectoryWay = path;
            return Files;
        }

        private static void StartFile(string path)//Запускает файл по данному пути
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        public static string[] GoBack()
        {
            if (NowDirectoryWay == null || NowDirectoryWay == "C:\\" || NowDirectoryWay == "D:\\")
            {
                NowDirectoryWay = "";
                return Discs;
            }
            else
            {
                DirectoryInfo NowDirect = new DirectoryInfo(NowDirectoryWay);
                //NowDirectoryWay = NowDirect.Parent.FullName;
                return GoToFile(NowDirect.Parent.FullName);
            }
        }

        public static string NameOfFile(string path)
        {
            return Path.GetFileName(path);
        }

        public static void DeletePath(string path)
        {
            if(File.Exists(path)) File.Delete(path);
            else
            {
                Directory.Delete(path, true);
            }
        }

        public static void RenameFile(string path, string NewName)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            di.MoveTo(di.Parent.FullName + "\\" + NewName);
        }

        public static void Copy(string OldPath, string NewPath)
        {
            if (File.Exists(OldPath)) File.Copy(OldPath, NewPath, false);
            else
            {
                RecursiveCopy(OldPath, NewPath);
            }
        }

        private static void RecursiveCopy(string OldPath, string NewPath)
        {
            Directory.CreateDirectory(NewPath);
            foreach (string CopiedFile in Directory.GetFiles(OldPath))
            {
                string NewFile = NewPath + "\\" + Path.GetFileName(CopiedFile);
                File.Copy(CopiedFile, NewFile, true);
            }
            foreach (string s in Directory.GetDirectories(OldPath))
            {
                RecursiveCopy(s, NewPath + "\\" + Path.GetFileName(s));
            }
        }

        
    }

}
