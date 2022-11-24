using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public interface IDeserializa <T> where T : new()
    {
        public bool Xml(out T datos);

        public bool Json(out T datos);
    }
}
