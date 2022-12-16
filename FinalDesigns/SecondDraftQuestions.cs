using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDesigns
{
    public partial class SecondDraftQuestions : Form
    {
        private int QuestionNumber;
        Dictionary<int, System.Windows.Forms.UserControl> Bestdictionary = new Dictionary<int, UserControl>();
        List<int> QuestionNumberOrder = new List<int>();
        public SecondDraftQuestions()
        {
            InitializeComponent();
        }

 

        private void SecondDraftQuestions_Load(object sender, EventArgs e)
        {
            Bestdictionary.Add(0, Qpnl1);
            Bestdictionary.Add(1, Qpnl2);
            Bestdictionary.Add(2, Qpnl3);
            Bestdictionary.Add(3, Qpnl4);
            Bestdictionary.Add(4, Qpnl5);
            Bestdictionary.Add(5, Qpnl6);
            Bestdictionary.Add(6, Qpnl7);
            Bestdictionary.Add(7, Qpnl8);
            Bestdictionary.Add(8, Qpnl9);
            Bestdictionary.Add(9, Qpnl10);
            Bestdictionary.Add(10, Qpnl11);
            Bestdictionary.Add(11, Qpnl12);
            Bestdictionary.Add(12, Qpnl13);
            Bestdictionary.Add(13, Qpnl14);
            Bestdictionary.Add(14, Qpnl15);
            Bestdictionary.Add(15, Qpnl16);
            Bestdictionary.Add(16, Qpnl17);
            Bestdictionary.Add(17, Qpnl18);
            Bestdictionary.Add(18, Qpnl19);
            Bestdictionary.Add(19, Qpnl20);
            QuestionNumber = 0;
            Random r = new Random();
            List<int> possible = Enumerable.Range(1, 20).ToList();
            
            for (int i = 0; i < 9; i++)
            {
                int index = r.Next(0, possible.Count);
                QuestionNumberOrder.Add(possible[index]);
                possible.RemoveAt(index);
            }
            Bestdictionary[QuestionNumberOrder[QuestionNumber]].Visible = true;
            Bestdictionary[QuestionNumberOrder[QuestionNumber]].BringToFront();
        }

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            QuestionNumber += 1;
            Bestdictionary[QuestionNumberOrder[QuestionNumber]].Visible = true;
            Bestdictionary[QuestionNumberOrder[QuestionNumber]].BringToFront();
            Bestdictionary[QuestionNumberOrder[(QuestionNumber-1)]].Visible = false;
        }
        private void QuestionPanel61_Load(object sender, EventArgs e)
        {

        }

        private void Qpnl5_Load(object sender, EventArgs e)
        {

        }

        private void questionPanel61_Load_1(object sender, EventArgs e)
        {

        }
    }
}
