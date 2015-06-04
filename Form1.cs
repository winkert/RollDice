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
    public partial class MainDiceRoll : Form
    {
        public MainDiceRoll()
        {
            InitializeComponent();
            if (System.IO.File.Exists(location))
            {
                oSettings = SystemSettings.OpenSettings(location);
            }
            else
            {
                oSettings = new SystemSettings();
            }
        }
        //Delegate for Roll
        public delegate void RollAction(object obj1, EventArgs e);
        public static String location = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\rolldice.bin";
        public static SystemSettings oSettings;
        //Public formats for textboxes
        public Font resultFont = new Font("Microsoft Sans Serif",12f);
        public BorderStyle resultBorder = BorderStyle.None;
        #region Public Methods
        public String printRoll(int[] d, int b)
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
            if (b > 0)
            {
                roll += " + " + b;
            }
            roll += " = " + (d.Sum() + b);
            return roll;
        }
        public int[] rollDice(int dDiceCount, int dDiceType)
        {
            Random rndRoll = new Random();
            int[] rolls = new int[dDiceCount];
            for (int i = 0; i < dDiceCount; i++)
            {
                rolls[i] = rndRoll.Next(1, dDiceType + 1);
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
            return rolls;
        }
        public int findBonus(String s)
        {
            if (s.IndexOf('+') > 0)
            {
                return int.Parse(s.Substring(s.IndexOf('+') + 1, s.Length - s.IndexOf('+') - 1));
            }
            else
            {
                return 0;
            }
        }
        public String removeBonus(String s)
        {
            if(s.IndexOf('+') > 0)
            {
                return s.Substring(0,s.IndexOf('+'));
            }
            else
            {
                return s;
            }
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
        public bool valideRoll(String r)
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
        public void resetUI()
        {
            if (oSettings.clearSearch)
            {
                this.txt_Roll.Text = String.Empty;
                this.txt_Roll.Focus(); 
            }
        }
        #endregion
        #region Event Handlers
        private void btn_Roll_Click(object sender, EventArgs e)
        {
            //If the sound file is there, play it
            if (oSettings.playSound)
            {
                try
                {
                    String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\diceroll.wav";
                    using (SoundPlayer p = new SoundPlayer(path))
                    {
                        p.PlaySync();
                    };
                }
                catch
                {
                    //Skip playing sound
                } 
            }
            //split the text up.
            List<string> allRolls = this.txt_Roll.Text.Split(new Char[] { ',', ';' }, System.StringSplitOptions.RemoveEmptyEntries).ToList();
            //Loop through the rolls
            foreach (String toss in allRolls)
            {
                int bonus = findBonus(toss);
                String roll = removeBonus(toss);
                //validate the roll
                if (!valideRoll(roll))
                {
                    MessageBox.Show("There was an error with the roll: " + toss + (char)10 + "Please enter a roll designation such as 3d6+1.");
                    //breaks on any error
                    return;
                }
                //split damage into two ints.
                int dDiceCount = countDice(roll);
                int dDiceType = findDiceType(roll);
                //roll the dice
                int[] rolls = rollDice(dDiceCount, dDiceType);
                //create textbox and add it to the panel
                TextBox result = new TextBox();
                result.Width = 300;
                result.Font = resultFont;
                result.BorderStyle = resultBorder;
                result.WordWrap = true;
                result.BackColor = this.ResultPanel.BackColor;
                //Here is where changes would need to be made in order to deal with combining or splitting results
                result.Text = printRoll(rolls, bonus);//This is where I can add the bonus
                result.Multiline = true;
                this.ResultPanel.Controls.Add(result); 
            }
            resetUI();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.ResultPanel.Controls.Clear();
            resetUI();
        }

        private void txt_Roll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RollAction rollTheDice = btn_Roll_Click;
                rollTheDice.Invoke(sender, e);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            s.Show();
        }
        #endregion
    }
}