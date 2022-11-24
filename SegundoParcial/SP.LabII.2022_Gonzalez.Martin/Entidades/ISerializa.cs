using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace EntidadesSP
{
    public interface ISerializa
    {
        

        public string PathXml { get; }
        public string PathJson { get; }
        public bool Xml();

        public bool Json();
        
    }
}
