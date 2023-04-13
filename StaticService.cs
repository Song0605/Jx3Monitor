using Jx3BaiZhanCDMonitor.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Jx3BaiZhanCDMonitor
{
    public static class StaticService
    {

        private static readonly string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string _programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        private static readonly string _dataFolderFilePath = "Jx3HuaJiu";

        public static readonly string AppdataFolderPath = Path.Combine(_appDataPath, _dataFolderFilePath);
        public static readonly string ProgramFilesFolderPath = Path.Combine(_programFilesPath, _dataFolderFilePath);
        public static readonly string UserBaseDataFileName = "UserBaseData";
        public static readonly string UserBaiZhanDataFileName = "UserBaiZhanData";
        public static readonly string FileExt = ".txt";

        public static List<Character> Characters { get; set; }

        public static bool CanViewAppdata { get; set; }
        public static bool CanViewProgramFiles { get; set; }

        public static MainWindowModel MainVm;
        static StaticService()
        {
            Characters = new List<Character>();
            MainVm = new MainWindowModel();

            CheckUserBaseFile();
        }
        #region 

        private static void CheckUserBaseFile()
        {
            var appFile = Path.Combine(AppdataFolderPath, UserBaseDataFileName + FileExt);
            var proFile = Path.Combine(ProgramFilesFolderPath, UserBaseDataFileName + FileExt);
            try
            {
                if (!File.Exists(appFile))
                    File.Create(appFile);
                if (!File.Exists(proFile))
                    File.Create(proFile);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        #endregion
    }
}
