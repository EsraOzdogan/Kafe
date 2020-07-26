using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    /*class RobotGarson
    {
    }*/
    public abstract class RobotGarson
    {
        IHareketBehavior hareketeden;
        IKonusmaBehavior konusan;
        
        public virtual void DoHareket()
        {
            this.hareketeden.Hareket();
        }

        public virtual void SetHareket(IHareketBehavior newHareketeden)
        {
            this.hareketeden = newHareketeden;
        }

        public virtual void DoKonusma()
        {
            this.konusan.Konusma();
        }

        public virtual void SetKonusma(IKonusmaBehavior newKonusan)
        {
            this.konusan = newKonusan;
        }
        /*
                public virtual void Swim()
                {
                    Console.WriteLine("Swish, swish");
                }*/
    }

    public class KadinRobot : RobotGarson
    {
        public KadinRobot()
        {
            SetHareket(new HizliHareketEtme());
            SetKonusma(new KadinGibiKonusma());
        }
    }

    public class ErkekRobot : RobotGarson
    {
        public ErkekRobot()
        {
            SetHareket(new YavasHareketEtme());
            SetKonusma(new ErkeGibiKonusma());
        }
    }
}
