using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe.Decorator;

namespace Kafe
{
    struct Icecek
    {
        public string cay;

        internal object GetDescription()
        {
            throw new NotImplementedException();
        }

        internal object GetCost()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Icecek(Limon v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Icecek(Tomurcuk v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Icecek(Karanfil v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Icecek(Seker v)
        {
            throw new NotImplementedException();
        }
    }
    class GözlemciGarson
    {
        private Icecek readings = new Icecek();
        public delegate void ChangeHandler(object sender, Icecek newReadings);
        public event ChangeHandler ChangeEvent;

        public void Change()
        {
            Notify();
        }

        public void UpdateReadings(Icecek newReadings)
        {
            this.readings = newReadings;
            Change();
        }

        private void Notify()
        {
            if (ChangeEvent != null)
                ChangeEvent(this, this.readings);
        }
    }
}
