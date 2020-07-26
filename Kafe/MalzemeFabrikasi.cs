using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{/*
    class MalzemeFabrikasi
    {
    }*/
    namespace SimpleFactory
    {
        public interface MMalzemeFabrikasi
        {
            Su SuOlustur();
            Siyah SiyahCayOlustur();
            Yesil YesilCayOlustur();
        }

        public class Su
        {
        }

        public class Siyah
        {
        }

        public class Yesil
        {
        }

        public class CinMalzemeFabrikasi : MMalzemeFabrikasi
        {
            #region MalzemeFabrikasi Members

            public Su SuOlustur()
            {
                Console.WriteLine("Cin");
                return new Su();
            }

            public Siyah SiyahCayOlustur()
            {
                Console.WriteLine("Cin");
                return new Siyah();
            }

            public Yesil YesilCayOlustur()
            {
                Console.WriteLine("Cin");
                return new Yesil();
            }

            #endregion
        }

        public class RizeMalzemeFabrikasi : MMalzemeFabrikasi
        {
            #region MalzemeFabrikasi Members

            public Su SuOlustur()
            {
                Console.WriteLine("Rize");
                return new Su();
            }

            public Siyah SiyahCayOlustur()
            {
                Console.WriteLine("Rize");
                return new Siyah();
            }

            public Yesil YesilCayOlustur()
            {
                Console.WriteLine("Rize");
                return new Yesil();
            }

            #endregion
        }

    }
}
