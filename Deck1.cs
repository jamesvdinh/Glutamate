using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_Math_Game
{
    public partial class Deck1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Deck1()
        {
            InitializeComponent();
        }

        private void Deck1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelCard1Q);
            listPanel.Add(panelCard2Q);
            listPanel.Add(panelCard3Q);
            listPanel.Add(panelCard4Q);
            listPanel.Add(panelCard5Q);
            listPanel.Add(panelCard6Q);
            listPanel.Add(panelCard7Q);
            listPanel.Add(panelCard8Q);
            listPanel.Add(panelCard9Q);
            listPanel.Add(panelCard10Q);


            listPanel[index].BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // NULL
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                listPanel[--index].BringToFront();
            }    
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }

        private void buttonFlip_Click(object sender, EventArgs e)
        {
            panelCard1A.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelCard2A.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelCard3A.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCard1Q.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelCard2Q.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelCard3Q.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCard4Q.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCard4A.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelCard5A.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelCard5Q.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelCard6A.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelCard6Q.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelCard7A.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelCard7Q.BringToFront();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            panelCard8A.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panelCard8Q.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelCard9A.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panelCard9Q.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panelCard10A.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelCard10Q.BringToFront();
        }
    }
}
