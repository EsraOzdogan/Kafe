using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    /* class CayStore
     {
     }*/
    namespace SimpleFactory
    {
        public abstract class CayStore
        {
            public Cay CaySiparis(string cayType)
            {
                Cay cay = CayOlustur(cayType);

                cay.Hazirlama();
                cay.Sukaynatma();
                cay.CayiIlaveEtme();
                cay.CayiDinlendirme();
                cay.FincanaKoyma();
                return cay;
            }

            protected abstract Cay CayOlustur(string type);
        }

        public class CinCayStore : CayStore
        {
            // portland-style preparation for all pizzas
            protected override Cay CayOlustur(string type)
            {
                Cay cay = null;

                if (type == "Siyah")
                    cay = new CinStiliSiyahCay();
                else if (type == "Yesil")
                    cay = new CinStiliYesilCay();
                /* else if (type == "Suede")
                     pizza = new PortlandStyleShoePizza();*/

                return cay;
            }
        }

        public class RizeCayStore : CayStore
        {
            // hillsboro-style preparation for all pizzas
            protected override Cay CayOlustur(string type)
            {
                Cay cay = null;

                if (type == "Siyah")
                    cay = new RizeStiliSiyahCay();
                else if (type == "Yesil")
                    cay = new RizeStiliYesilCay();
                /*else if (type == "Suede")
                    cay = new HillsboroStyleShoePizza();*/

                return cay;
            }
        }
    }

}
