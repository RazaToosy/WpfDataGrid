using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Core.Models;
using Utilities.Commands;
using Utilities.Data;
using Utilities.IO;

namespace UI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<ModelAssociatedEntries> _data;

        public ObservableCollection<ModelAssociatedEntries> Data
        {
            get { return _data; }
            set
            {
                _data = value;
                RaisePropertyChanged("Data");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ExportCommand { get; set; }

        public MainViewModel()
        {
            GetData();
            ExportCommand = new ButtonCommand(ExportToXML, CanExportToXml);
        }

        private bool CanExportToXml(object obj)
        {
            return true;
        }

        private void ExportToXML(object data)
        {
            //Code to Export data to XML. 
            if (_data != null)
            {
                var DataToExport = _data.Where(x => x.Export).ToList();

                new ExportToXml(DataToExport).Export();

                var cleanData = new ObservableCollection<ModelAssociatedEntries>(_data.Select(x =>
                {
                    x.Export = false;
                    return x;
                }).ToList());

                Data.Clear();

                Data = cleanData;
            }
            //Takes Data and strips out those who have been ticked then export to XML
        }

        private async void GetData()
        {
            Data = await Task.Run(() =>
            {
                var repo = new Repo().Data;
                return repo;
            });
        }


    }
}
