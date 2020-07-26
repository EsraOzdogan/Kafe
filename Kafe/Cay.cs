using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    public abstract class Cay
    {
        public virtual void Hazirlama()
        {
            Console.WriteLine("Standart hazirlama.");
        }

        public virtual void Sukaynatma()
        {
            Console.WriteLine("Standart su kaynatma.");
        }

        public virtual void CayiIlaveEtme()
        {
            Console.WriteLine("Standart cayi ekleme.");
        }
        public virtual void CayiDinlendirme()
        {
            Console.WriteLine("Standart cayi dinlendirme.");
        }
        public virtual void FincanaKoyma()
        {
            Console.WriteLine("Standart cay doldurma.");
        }
    }
}
