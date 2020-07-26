using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Kafe.SimpleFactory;
using Kafe.Decorator;

namespace Kafe
{
    public partial class MENÜ : Form
    {
        public MENÜ()
        {

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

           /* CurrentConditions conditions = new CurrentConditions(siparis);
            KararDegisikligi kararDegisikligi = new KararDegisikligi(siparis);*/


            // create the readings
            Icecek readings = new Icecek();
            readings.cay = "yesil cay";

            // update the readings - everyone should print



            Console.ReadLine();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

           /* Icecek ic = new Cay();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));
            ic = new Limon(ic);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           /* Icecek ic = new Cay();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));*/
            CayStore store = new RizeCayStore();
            store.CaySiparis("Siyah");
           

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            CayStore store = new RizeCayStore();
            store.CaySiparis("Yeşil");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CayStore store = new CinCayStore();
            store.CaySiparis("Siyah");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CayStore store = new CinCayStore();
            store.CaySiparis("Yeşil");
        }

        private void button7_Click(object sender, EventArgs e)
        {
           /* Icecek ic = new Cay();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));
            ic = new Seker(ic);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* Icecek ic = new Cay();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));
            ic = new Tomurcuk(ic);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
           /* Icecek ic = new Cay();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));
            ic = new Karanfil(ic);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    ic.GetDescription(),
                    ic.GetCost()));*/
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Masalar.ActiveForm.Visible = false;
            Form4 formac = new Form4();
            formac.Show();
        }
    }

    internal class Siparis
    {
    }
}
