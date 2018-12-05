using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core.Models;

namespace Utilities.IO
{
    public class ExportToXml
    {
        private List<ModelAssociatedEntries> _dataToExport;
        public ExportToXml(List<ModelAssociatedEntries> DataToExport)
        {
            _dataToExport = DataToExport;
            Export();
        }

        public void Export()
        {
            XDocument xDoc = new XDocument(
                new XElement("Events", _dataToExport.Select(e =>
                    new XElement("Event",
                        new XAttribute("id", Guid.NewGuid()),
                        new XAttribute("Name", e.Term),
                        new XAttribute("ReadCode", e.ReadCode),
                        new XAttribute("SnomedCode", e.ConceptId)
                        ))));
            xDoc.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Events.xml"));
        }
    }
}
