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
    public partial class PersonalDeck : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public PersonalDeck(Deck Deck)
        {
            InitializeComponent();
            labelQ1.Text = Deck.Q1.ToString();
            labelQ2.Text = Deck.Q2.ToString();
            labelQ3.Text = Deck.Q3.ToString();
            labelQ4.Text = Deck.Q4.ToString();
            labelQ5.Text = Deck.Q5.ToString();
            labelA1.Text = Deck.A1.ToString();
            labelA2.Text = Deck.A2.ToString();
            labelA3.Text = Deck.A3.ToString();
            labelA4.Text = Deck.A4.ToString();
            labelA5.Text = Deck.A5.ToString();

            labelName1A.Text = Deck.Name.ToString();
            labelName2A.Text = Deck.Name.ToString();
            labelName3A.Text = Deck.Name.ToString();
            labelName4A.Text = Deck.Name.ToString();
            labelName5A.Text = Deck.Name.ToString();
            labelName1Q.Text = Deck.Name.ToString();
            labelName2Q.Text = Deck.Name.ToString();
            labelName3Q.Text = Deck.Name.ToString();
            labelName4Q.Text = Deck.Name.ToString();
            labelName5Q.Text = Deck.Name.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelCard1Q.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panelCard1A.BringToFront();
        }

        private void PersonalDeck_Load(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            panelCard5Q.BringToFront();
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
    }
}
