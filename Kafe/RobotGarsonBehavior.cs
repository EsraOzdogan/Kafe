using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    class RobotGarsonBehavior
    {
    }
    public class HizliHareketEtme : IHareketBehavior
    {
        public void Hareket()
        {
            Console.WriteLine("Hizli Hareket Etme.");
        }
    }

    public class YavasHareketEtme : IHareketBehavior
    {
        public void Hareket()
        {
            Console.WriteLine("Yavas Hareket Etme.");
        }
    }

    public class KadinGibiKonusma : IKonusmaBehavior
    {
        public void Konusma()
        {
            Console.WriteLine("Buyrun,Hosgeldiniz");
        }
    }

    public class ErkeGibiKonusma : IKonusmaBehavior
    {
        public void Konusma()
        {
            Console.WriteLine("Evet ne istemiştiniz");
        }
    }

}
