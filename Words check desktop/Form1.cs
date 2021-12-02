using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Words_check_desktop
{
    public partial class Form1 : Form
    {
        private string norFilePath;
        private string engFilePath;
        int result = 0;
        public int ShuffleNor()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int r = 0;

            //string[] nor = File.ReadAllLines(this.norFilePath).ToArray();

            string[] nor = File.ReadAllLines(@"C:\Users\Kapi\Desktop\NOR TXT\no.txt").ToArray();

            Random rnd = new Random();
            r = rnd.Next(0, nor.Length);
            lbl_nor.Text = nor[r];
            return r;

        }
        public Form1()
        {
            InitializeComponent();
        }

        int _lastShuffleResult = 0;
        int total = 0;
        int correct = 0;
        bool answer = false;
        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            _lastShuffleResult = ShuffleNor();
            lbl_eng.Text = null;
            if (result == 1)
            {
                result = 0;
                total = 0;
                correct = 0;
                lbl_result.Text = null;
            }
            answer = true;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            //string[] eng = File.ReadAllLines(this.engFilePath).ToArray();

            string[] eng = File.ReadAllLines(@"C:\Users\Kapi\Desktop\NOR TXT\en.txt").ToArray();

            lbl_eng.Text = eng[_lastShuffleResult];
        }
        
        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (answer == true)
            {
                total++;
                correct++;
            }
            answer = false;
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (answer == true)
            {
                total++;
            }
            answer = false;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            lbl_result.Text = $"Your result is {correct}/{total}";
            result = 1;
        }


        private void btn_loadnor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            var a = openFileDialog1.OpenFile();
            this.norFilePath = openFileDialog1.FileName;


        }

        private void btn_loadeng_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.ShowDialog();
            var a = openFileDialog2.OpenFile();
            this.engFilePath = openFileDialog2.FileName;
        }
    }
}