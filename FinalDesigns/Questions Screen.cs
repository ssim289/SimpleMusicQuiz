using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuestionLbl_Click(object sender, EventArgs e)
        {

        }

        private void BtnD_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void Button86_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Dictionary<int, System.Windows.Forms.Panel> Bestdictionary = new Dictionary<int, System.Windows.Forms.Panel>();
            Bestdictionary.Add(0, pnlQuestion1);
            Bestdictionary.Add(1, pnlQuestion2);
            Bestdictionary.Add(2, pnlQuestion3);
            Bestdictionary.Add(3, pnlQuestion4);
            Bestdictionary.Add(4, pnlQuestion5);
            Bestdictionary.Add(5, pnlQuestion6);
            Bestdictionary.Add(6, pnlQuestion7);
            Bestdictionary.Add(7, pnlQuestion8);
            Bestdictionary.Add(8, pnlQuestion9);
            Bestdictionary.Add(9, pnlQuestion10);
            Bestdictionary.Add(10, pnlQuestion11);
            Bestdictionary.Add(11, pnlQuestion12);
            Bestdictionary.Add(12, pnlQuestion13);
            Bestdictionary.Add(13, pnlQuestion14);
            Bestdictionary.Add(14, pnlQuestion15);
            Bestdictionary.Add(15, pnlQuestion16);
            Bestdictionary.Add(16, pnlQuestion17);
            Bestdictionary.Add(17, pnlQuestion18);
            Bestdictionary.Add(18, pnlQuestion19);
            Bestdictionary.Add(19, pnlQuestion20);
            int QuestionNumber = 0;
            Random r = new Random();
            List<int> possible = Enumerable.Range(1, 20).ToList();
            List<int> QuestionNumberOrder = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                int index = r.Next(0, possible.Count);
                QuestionNumberOrder.Add(possible[index]);
                possible.RemoveAt(index);
            }
            Bestdictionary[QuestionNumberOrder[QuestionNumber]].Visible = true;
            Bestdictionary[QuestionNumberOrder[QuestionNumber]].BringToFront();
        }
    }
}
