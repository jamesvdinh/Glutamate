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
    public partial class Home : Form
    {
        internal static FlashcardCreator Creator;
        internal static PersonalDeck PersonalDeck;
        internal static Home home;
        public Home()
        {
            InitializeComponent();
            home = this;
        }

        public static List<Deck> PersonalDecks = new List<Deck>();

        public void UpdateDecks(List<Deck> PersonalDecks)
        {
            listBoxDecks.Items.Clear();
            foreach (Deck deck in PersonalDecks)
                listBoxDecks.Items.Add(deck.Name);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            // NULL
        }

        private void labelApp_Click(object sender, EventArgs e)
        {
            // NULL
        }

        private void buttonDeck1_Click(object sender, EventArgs e)
        {
            Deck1 Deck1 = new Deck1();
            Deck1.Show();
        }

        private void buttonDeck2_Click(object sender, EventArgs e)
        {
            Deck2 Deck2 = new Deck2();
            Deck2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creator = new FlashcardCreator();
            Creator.Show();
        }
        public static Deck current = new Deck();
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            int index;
            index = listBoxDecks.SelectedIndex;
            PersonalDeck = new PersonalDeck(current);
            PersonalDeck.Show();
        }
        
        private void listBoxDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            labelDetails.Text = "";
            foreach (Deck deck in PersonalDecks)
            {
                try
                {
                    if (listBoxDecks.SelectedItem.ToString() == deck.Name)
                    {
                        current = deck;
                        labelDetails.Text = "Deck name: " + current.Name + "\n" +
                            "Questions: " + current.Count + "\n" +
                            "Estimated Time: " + current.Duration + " minutes \n";
                    }
                    else
                        continue;
                }
                catch
                {
                    continue;
                }
            }
        }

        private void labelDetails_Click(object sender, EventArgs e)
        {
            // NULL
        }
    }
}
