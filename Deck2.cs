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
    public partial class Deck2 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Deck2()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panelCard1A.BringToFront();
        }

        private void Deck2_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelCard1Q);
            listPanel.Add(panelCard2Q);
            listPanel.Add(panelCard3Q);
            listPanel.Add(panelCard4Q);
            listPanel.Add(panelCard5Q);

            listPanel[index].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCard2A.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCard2Q.BringToFront();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCard3A.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelCard3Q.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelCard4A.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelCard4Q.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelCard5A.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelCard5Q.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelCard1Q.BringToFront();
        }
    }
}
