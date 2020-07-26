using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{

    /*class GörenekCay
    {
    }*/
    namespace SimpleFactory
    {
        class CinStiliSiyahCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Çin stili görenek siyah cay yapma.");
            }
        }
        class CinStiliYesilCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Çin stili görenek yesil cay yapma.");
            }
        }
        class CinStiliBeyazCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Çin stili görenek beyaz cay yapma.");
            }
        }
        class CinStiliOolongCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Çin stili görenek oolong cayi yapma.");
            }
        }
        class CinStilipuerhCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Çin stili görenek  pu-erh cayi yapma.");
            }
        }
        class RizeStiliSiyahCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Rize stili görenek siyah cay yapma.");
            }
        }

        class RizeStiliYesilCay : Cay
        {
            public override void Hazirlama()
            {
                Console.WriteLine("Rize stili görenek yesil cay yapma.");
            }
        }
    }

}
