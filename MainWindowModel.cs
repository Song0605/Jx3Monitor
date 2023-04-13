using Jx3BaiZhanCDMonitor.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Jx3BaiZhanCDMonitor
{
    public class MainWindowModel
    {
        public ObservableCollection<Character> CharacterList { get; set; }
        public MainWindowModel()
        {
            CharacterList = new ObservableCollection<Character>();

            if (!CheckJsonFiles())
                CreateJsonFiles();

            if (!CheckWeeklyRefreshStatus())
                ResetStatus();

            CharacterList.CollectionChanged -= CharacterList_CollectionChanged;
            CharacterList.CollectionChanged += CharacterList_CollectionChanged;
        }
        private bool CheckJsonFiles()
        {
            return true;
            return false;
        }
        private void CreateJsonFiles()
        {

        }

        private bool CheckWeeklyRefreshStatus()
        {
            return true;
            return false;
        }

        private void ResetStatus()
        {

        }
        public void RefreshJsonFile()
        {
            JsonConvert.SerializeObject(CharacterList);
        }

        private void CharacterList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshJsonFile();
        }

        public void RefreshData()
        {
            CharacterList.Add(new Character()
            {
                Name = "12312"
            });
        }
    }
}
