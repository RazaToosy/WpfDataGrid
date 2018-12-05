using System.Collections.Generic;
using System.Linq;
using Core.Interfaces;
using Core.Models;
using LinqToExcel;

namespace Utilities.IO
{
    public class ImportXLSX : IImportData<ModelAssociatedEntries>
    {
        public IList<ModelAssociatedEntries> FetchList(string FileName)
        {
            var excel = new ExcelQueryFactory();
            excel.FileName = FileName;
            return excel.Worksheet<ModelAssociatedEntries>().Select(x => x).ToList();
        }
    }
}
