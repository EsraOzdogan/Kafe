using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    namespace Decorator
    {
        public abstract class Icecek
        {
            public string description = "Bilinmeyen icecek";

            public virtual string GetDescription()
            {
                return this.description;
            }

            public abstract double GetCost();
        }

        public class Cay : Icecek
        {
            public Cay()
            {
                this.description = "Cay";
            }

            public override double GetCost()
            {
                return 2.00;
            }
        }



        public abstract class CondimentDecorator : Icecek
        {
        }

        public class Seker : CondimentDecorator
        {
            Icecek icecek;
            private Kafe.Icecek ic;

            public Seker(Icecek newIcecek)
            {
                this.icecek = newIcecek;
            }

          /*  public Seker(Kafe.Icecek ic)
            {
                this.ic = ic;
            }*/

            public override string GetDescription()
            {
                return this.icecek.GetDescription() + ", Seker " +
                    this.GetCost();
            }

            public override double GetCost()
            {
                return 0.20 + this.icecek.GetCost();
            }
        }


        public class Karanfil : CondimentDecorator
        {
            Icecek icecek;
            private Kafe.Icecek ic;

            public Karanfil(Icecek newIcecek)
            {
                this.icecek = newIcecek;
            }

         /*   public Karanfil(Kafe.Icecek ic)
            {
                this.ic = ic;
            }
         */
            public override string GetDescription()
            {
                return this.icecek.GetDescription() + ", Karanfil " +
                    this.GetCost();
            }

            public override double GetCost()
            {
                return 0.70 + this.icecek.GetCost();
            }
        }


        public class Tomurcuk : CondimentDecorator
        {
            Icecek icecek;
            private Kafe.Icecek ic;

            public Tomurcuk(Icecek newIcecek)
            {
                this.icecek = newIcecek;
            }

           /* public Tomurcuk(Kafe.Icecek ic)
            {
                this.ic = ic;
            }*/

            public override string GetDescription()
            {
                return this.icecek.GetDescription() + ", Tomurcuk " +
                    this.GetCost();
            }

            public override double GetCost()
            {
                return 0.50 + this.icecek.GetCost();
            }
        }

        public class Limon : CondimentDecorator
        {
            Icecek icecek;
            private Kafe.Icecek ic;

            public Limon(Icecek newIcecek)
            {
                this.icecek = newIcecek;
            }

           /* public Limon(Kafe.Icecek ic)
            {
                this.ic = ic;
            }*/

            public override string GetDescription()
            {
                return this.icecek.GetDescription() + ", Limon " +
                    this.GetCost();
            }

            public override double GetCost()
            {
                return 0.20 + this.icecek.GetCost();
            }
        }
    }

}
