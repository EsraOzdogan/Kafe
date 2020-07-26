using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("KadinRobot");
            KadinRobot kadinrobot = new KadinRobot();
            Helper(kadinrobot);

            Console.ReadLine();
            void Helper(RobotGarson myRobotGarson)
            {
                /*  myDuck.Swim();*/
                myRobotGarson.DoHareket();
                myRobotGarson.DoKonusma();
            }
            Masalar.ActiveForm.Visible = false;
            MENÜ formac = new MENÜ();
            formac.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ErkekRobot");
            ErkekRobot erkekrobot = new ErkekRobot();
            Helper(erkekrobot);
           void Helper(RobotGarson myRobotGarson)
            {
                /*  myDuck.Swim();*/
                myRobotGarson.DoHareket();
                myRobotGarson.DoKonusma();
            }
            Masalar.ActiveForm.Visible = false;
            MENÜ formac = new MENÜ();
            formac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("KadinRobot");
            KadinRobot kadinrobot = new KadinRobot();
            Helper(kadinrobot);
            void Helper(RobotGarson myRobotGarson)
            {
                /*  myDuck.Swim();*/
                myRobotGarson.DoHareket();
                myRobotGarson.DoKonusma();
            }
            Masalar.ActiveForm.Visible = false;
            MENÜ formac = new MENÜ();
            formac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ErkekRobot");
            ErkekRobot erkekrobot = new ErkekRobot();
            Helper(erkekrobot);
            void Helper(RobotGarson myRobotGarson)
            {
                /*  myDuck.Swim();*/
                myRobotGarson.DoHareket();
                myRobotGarson.DoKonusma();
            }
            Masalar.ActiveForm.Visible = false;
            MENÜ formac = new MENÜ();
            formac.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ErkekRobot");
            ErkekRobot erkekrobot = new ErkekRobot();
            Helper(erkekrobot);
            void Helper(RobotGarson myRobotGarson)
            {
                /*  myDuck.Swim();*/
                myRobotGarson.DoHareket();
                myRobotGarson.DoKonusma();
            }
            Masalar.ActiveForm.Visible = false;
            MENÜ formac = new MENÜ();
            formac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("KadinRobot");
            KadinRobot kadinrobot = new KadinRobot();
            Helper(kadinrobot);
            void Helper(RobotGarson myRobotGarson)
            {
                /*  myDuck.Swim();*/
                myRobotGarson.DoHareket();
                myRobotGarson.DoKonusma();
            }
            Masalar.ActiveForm.Visible = false;
            MENÜ formac = new MENÜ();
            formac.Show();
        }

        private void Masalar_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Masalar.ActiveForm.Visible = false;
            ÇayDiyarı formac = new ÇayDiyarı();
            formac.Show();
        }
    }
}
