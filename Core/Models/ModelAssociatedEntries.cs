using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ModelAssociatedEntries// : INotifyPropertyChanged
    {
        public bool Export { get; set; }
        public int ID { get; set; }
        public string ReadCode { get; set; }
        public string Term { get; set; }
        public string ConceptId { get; set; }
        public string DescriptionId { get; set; }

        //private bool _export;
        //private int _iD;
        //private string _readCode;
        //private string _term;
        //private string _conceptId;
        //private string _descriptionId;

        //public bool Export
        //{
        //    get=>_export;
        //    set
        //    {
        //        _export = value;
        //        OnPropertyChanged(nameof(Export));
        //    }
        //}

        //public int ID
        //{
        //    get => _iD;
        //    set
        //    {
        //        _iD = value;
        //        OnPropertyChanged(nameof(ID));
        //    }
        //}

        //public string ReadCode
        //{
        //    get => _readCode;
        //    set
        //    {
        //        _readCode = value;
        //        OnPropertyChanged(nameof(ReadCode));
        //    }
        //}

        //public string Term
        //{
        //    get => _term;
        //    set
        //    {
        //        _term = value;
        //        OnPropertyChanged(nameof(Term));
        //    }
        //}

        //public string ConceptId
        //{
        //    get => _conceptId;
        //    set
        //    {
        //        _conceptId = value;
        //        OnPropertyChanged(nameof(ConceptId));
        //    }
        //}

        //public string DescriptionId
        //{
        //    get => _descriptionId;
        //    set
        //    {
        //        _descriptionId = value;
        //        OnPropertyChanged(nameof(DescriptionId));
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
    }
}
