using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaconSvr;

namespace ScadaTelas.Controlador
{
    class ServidorFatek : FaconSvr.FaconServer 
    {
        protected ServidorFatek()
        {
        }
        protected ServidorFatek(string p): this()
        {
        }
        internal static FaconServer CreateObject(string p)
        {
            return new FaconServer(p);
        }

        internal void OpenProject(string p)
        {
            throw new NotImplementedException();
        }

        internal void Connect()
        {
            throw new NotImplementedException();
        }

        internal string GetItem(string p, string p_2)
        {
            throw new NotImplementedException();
        }
    }
}
