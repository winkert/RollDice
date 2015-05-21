using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RollDiced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String rollDice(int[] d)
        {
            String roll = "";
            for (int i = 0; i < d.Count(); i++)
            {
                roll += d[i].ToString();
                if (i != d.Count() - 1)
                {
                    roll += " + ";
                }
            }
            roll += " = " + d.Sum();
            return roll;
        }
        public int countDice(String s)
        {
            int toD = s.IndexOf('d');
            if (toD < 1)
            {
                return 0;
            }
            return int.Parse(s.Substring(0,toD));
        }
        public int findDiceType(String s)
        {
            int toD = s.IndexOf('d');
            int len = s.Length;
            if (toD < 1)
            {
                return 0;
            }
            return int.Parse(s.Substring(toD + 1, len - (toD + 1)));
        }
        public bool validateRoll(String r)
        {
            if(r == string.Empty) return false;
            if (r.Count(s => s == 'd') != 1) return false;
            if (r.IndexOf('d') < 1) return false;
            return true;
        }
        public int rollWild(int i)
        {
            Random rnd = new Random();
            int roll = i;
            int wildRoll = roll;
            while (roll == i)
            {
                roll = rnd.Next(1, i);
                wildRoll += roll;
            }
            return wildRoll;
        }
        private void btn_Roll_Click(object sender, EventArgs e)
        {
            if (!validateRoll(this.txt_Roll.Text))
            {
                MessageBox.Show("Please enter a roll designation such as 3d6.");
                return;
            }
            //String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\diceroll.wav";
            //using (SoundPlayer p = new SoundPlayer(path))
            //{
            //    p.PlaySync();
            //};
            int dDiceCount;
            int dDiceType;
            String damage;
            Random rndRoll = new Random();
            damage = this.txt_Roll.Text;
            //split damage into two ints.
            dDiceCount = countDice(damage);
            dDiceType = findDiceType(damage);
            int[] rolls = new int[dDiceCount];
            for (int i = 0; i < dDiceCount; i ++)
            {
                rolls[i] = rndRoll.Next(1,dDiceType+1);
                if (i == dDiceCount - 1)
                {
                    if (isWild.Checked && (rolls[i] == dDiceType))
                    {
                        rolls[i] = rollWild(rolls[i]);
                    }
                    if (isCritical.Checked && (rolls[i] == 1))
                    {
                        rolls[i] = 0;
                        int maxRoll = rolls.Max();
                        bool f = false;
                        int j = 0;
                        while (!f)
                        {
                            if (rolls[j] == maxRoll)
                            {
                                rolls[j] = 0;
                                f = true;
                            }
                            j++;
                        }
                        
                    }
                }
            }
            this.results.Text = rollDice(rolls);
        }
    }
}
