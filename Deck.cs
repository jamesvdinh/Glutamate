using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard_Math_Game
{
    public class Deck
    {
        private string name;

        private string q1;
        private string a1;

        private string q2;
        private string a2;

        private string q3;
        private string a3;

        private string q4;
        private string a4;

        private string q5;
        private string a5;

        private int index;
        private int duration;
        private int count;

        public Deck()
        {
            name = "NULL";

            q1 = "";
            a1 = "";

            q2 = "";
            a2 = "";

            q3 = "";
            a3 = "";

            q4 = "";
            a4 = "";

            q5 = "";
            a5 = "";

            index = 0;
            duration = 0;
            count = 0;
        }

        public Deck(string newname, string newQ1, string newA1, string newQ2, string newA2, string newQ3, string newA3, string newQ4, string newA4, string newQ5, string newA5, int newindex, int newduration, int newcount)
        {
            name = newname;

            q1 = newQ1;
            a1 = newA1;

            q2 = newQ2;
            a2 = newA2;

            q3 = newQ3;
            a3 = newA3;

            q4 = newQ4;
            a4 = newA4;

            q5 = newQ5;
            a5 = newA5;

            index = newindex;
            duration = newduration;
            count = newcount;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Q1
        {
            get { return q1; }
            set { q1 = value; }
        }
        public string Q2
        {
            get { return q2; }
            set { q2 = value; }
        }
        public string Q3
        {
            get { return q3; }
            set { q3 = value; }
        }
        public string Q4
        {
            get { return q4; }
            set { q4 = value; }
        }
        public string Q5
        {
            get { return q5; }
            set { q5 = value; }
        }
        public string A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        public string A2
        {
            get { return a2; }
            set { a2 = value; }
        }
        public string A3
        {
            get { return a3; }
            set { a3 = value; }
        }
        public string A4
        {
            get { return a4; }
            set { a4 = value; }
        }
        public string A5
        {
            get { return a5; }
            set { a5 = value; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
