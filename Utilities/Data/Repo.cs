using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Utilities.IO;
using Utilities.Properties;

namespace Utilities.Data
{
    public class Repo
    {

        private  ObservableCollection<ModelAssociatedEntries> _data;

        public Repo()
        {
            GetData();
        }

        private async void GetDataAsync()
        {
            await Task.Run(() =>
            {
                IImportData<ModelAssociatedEntries> importData = new ImportXLSX();
                var pathOfExcelFile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,
                    Settings.Default.NameOfExcelFile);
                _data = new ObservableCollection<ModelAssociatedEntries>(importData.FetchList(pathOfExcelFile));
            });
        }

        private void GetData()
        {
            IImportData<ModelAssociatedEntries> importData = new ImportXLSX();
            var pathOfExcelFile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,
                Settings.Default.NameOfExcelFile);
            _data = new ObservableCollection<ModelAssociatedEntries>(importData.FetchList(pathOfExcelFile));
        }


        public ObservableCollection<ModelAssociatedEntries> Data
        {
            get { return _data; }
        }

    }
}
