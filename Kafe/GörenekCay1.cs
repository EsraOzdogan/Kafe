using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    /* class GörenekCay1
     {
     }*/
    namespace SimpleFactory
    {
        class SiyahCay : Cay
        {
            MMalzemeFabrikasi malzemeFabrikasi;

            public SiyahCay(MMalzemeFabrikasi görenekMalzemeFabrikasi)
            {
                this.malzemeFabrikasi = görenekMalzemeFabrikasi;
            }

            public override void Hazirlama()
            {
                Console.WriteLine("Görenek siyah cay yapmak.");
                this.malzemeFabrikasi.SuOlustur();
                this.malzemeFabrikasi.SiyahCayOlustur();
                /*this.malzemeFabrikasi.YesilCayOlustur();*/
            }
        }

        class YesilCay : Cay
        {
            MMalzemeFabrikasi malzemeFabrikasi;

            public YesilCay(MMalzemeFabrikasi görenekMalzemeFabrikasi)
            {
                this.malzemeFabrikasi = görenekMalzemeFabrikasi;
            }

            public override void Hazirlama()
            {
                Console.WriteLine("Making custom sea-creature pizza.");
                this.malzemeFabrikasi.SuOlustur();
                /*  this.malzemeFabrikasi.SiyahCayOlustur();*/
                this.malzemeFabrikasi.YesilCayOlustur();
            }
        }

        /* class ShoePizza : Pizza
         {
             IIngredientFactory ingredientFactory;

             public ShoePizza(IIngredientFactory customIngredientFactory)
             {
                 this.ingredientFactory = customIngredientFactory;
             }

             public override void Prepare()
             {
                 Console.WriteLine("Making custom orthopedic pizza.");
                 this.ingredientFactory.CreateDough();
                 this.ingredientFactory.CreateSauce();
                 this.ingredientFactory.CreateCheese();
             }
         }*/
    }

}
