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
    public partial class FlashcardCreator : Form
    {
        public FlashcardCreator()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Deck Deck = new Deck();

            Deck.Name = textBoxName.Text;

            if (textBoxQ1.Text != "")
            {
                Deck.Count++;
                Deck.Q1 = textBoxQ1.Text;
                Deck.A1 = textBoxA1.Text;
            }

            if (textBoxQ2.Text != "")
            {
                Deck.Count++;
                Deck.Q2 = textBoxQ2.Text;
                Deck.A2 = textBoxA2.Text;
            }

            if (textBoxQ3.Text != "")
            {
                Deck.Count++;
                Deck.Q3 = textBoxQ3.Text;
                Deck.A3 = textBoxA3.Text;
            }

            if (textBoxQ4.Text != "")
            {
                Deck.Count++;
                Deck.Q4 = textBoxQ4.Text;
                Deck.A4 = textBoxA4.Text;
            }

            if (textBoxQ5.Text != "")
            {
                Deck.Count++;
                Deck.Q5 = textBoxQ5.Text;
                Deck.A5 = textBoxA5.Text;
            }
            
            Deck.Index = Home.PersonalDecks.Count;
            Deck.Duration = Deck.Count;
            Home.PersonalDecks.Add(Deck);
            Home.home.UpdateDecks(Home.PersonalDecks);

            foreach (Deck deck in Home.PersonalDecks)
            {
                Deck.Index = Home.PersonalDecks.IndexOf(Deck);
            }

            MessageBox.Show("Deck Created!");
            this.Close();
        }
    }
}
