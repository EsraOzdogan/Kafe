using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    /* class CayStore1
     {
     }*/
    namespace SimpleFactory
    {
        public abstract class CayStore1
        {
            public Cay CaySiparis(string pizzaType)
            {
                Cay cay = CayOlustur(pizzaType);

                cay.Hazirlama(); // abstract factory pattern
                cay.Sukaynatma();
                cay.CayiIlaveEtme();
                cay.CayiDinlendirme();
                cay.FincanaKoyma();
                return cay;
            }

            protected abstract Cay CayOlustur(string type);
        }

        public class CinCayStore1 : CayStore
        {
            // portland-style preparation for all pizzas
            protected override Cay CayOlustur(string type)
            {
                Cay cay = null;
                MMalzemeFabrikasi malzemeFabrikasi =
                    new CinMalzemeFabrikasi();

                if (type == "Siyah")
                    cay = new SiyahCay(malzemeFabrikasi);
                else if (type == "Yesil")
                    cay = new YesilCay(malzemeFabrikasi);
                /* else if (type == "Suede")
                     pizza = new ShoePizza(ingredientFactory);*/

                return cay;
            }
        }

        public class RizeCayStore1 : CayStore
        {
            // hillsboro-style preparation for all pizzas
            protected override Cay CayOlustur(string type)
            {
                Cay cay = null;
                MMalzemeFabrikasi malzemeFabrikasi =
                    new RizeMalzemeFabrikasi();

                if (type == "Siyah")
                    cay = new SiyahCay(malzemeFabrikasi);
                else if (type == "Yesil")
                    cay = new YesilCay(malzemeFabrikasi);
                /*  else if (type == "Suede")
                      pizza = new ShoePizza(malzemeFabrikasi);*/

                return cay;
            }
        }
    }

}
