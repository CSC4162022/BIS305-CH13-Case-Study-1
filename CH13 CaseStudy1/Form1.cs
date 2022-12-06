using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        const int MAX_CONTESTANTS = 30;
        List<Contestant> contestants = new List<Contestant>();
        List<string> result = new List<string>();
        //Contestant[] contestants = new Contestant[MAX_CONTESTANTS];
        int contestantsNum;
        public int remainingContestants;
        int revenue = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //assign and display number of contestants
        private void submitContestantsNum_Click(object sender, EventArgs e)
        {
            contestantsNum = Int32.Parse(contestantNum.Text);
            revenue = contestantsNum * 25;
            if (contestantsNum < 0 || contestantsNum > 30)
            {
                MessageBox.Show("Invalid entry");
                contestantsNum = 0;
            }
            else
            {
                //resize the array to num of contestants
                //Array.Resize(ref contestants, contestantsNum);
                remainingContestants = contestantsNum;
                lblDisplayContestantNum.Text = "Contestants: " + contestantsNum.ToString();              
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmitContestantData_Click(object sender, EventArgs e)
        {   
            const int ADULTAGE = 17;
            const int TEENAGE = 12;
            bool valid = false;
            string name;
            char talent;
            int age;
            name = txtContestantName.Text.ToString();
            age = Int32.Parse(txtContestantAge.Text);
            talent = Char.Parse(txtContestantTalentCode.Text);
           
            if (age > 0 && age < 120)
            {
                for (int y = 0; y < Contestant.talentCodes.Length; y++)
                {
                    if (Contestant.talentCodes[y] == talent)
                    {
                        valid = true;
                    }
                }
                if (valid)
                {

                    Contestant contestant = new Contestant();
                    if (age > ADULTAGE)
                        contestant.Fee = 30;
                    else
                    if (age > TEENAGE)
                        contestant.Fee = 20;
                    else
                        contestant.Fee = 15;

                    contestant.Name = name;
                    contestant.TalentCode = talent;
                    contestants.Add(contestant);
                    revenue += contestant.Fee;
                    result.Add(" Name: " + contestant.Name + " Talent: " + contestant.Talent);
                    remainingContestants--;
                    lblRemainingContestants.Text = "Remaining contestants to enter: " + remainingContestants.ToString();
                    txtContestantAge.Text=string.Empty;
                    txtContestantName.Text = string.Empty;
                    txtContestantTalentCode.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Invalid talent entered");
                }
            }
            else
            {
                MessageBox.Show("Invalid age entered");
            }
        }

        private void btnGetResults_Click(object sender, EventArgs e)
        {
            string concatResult = "";
            foreach (string res in result)
            {
                concatResult = concatResult + res;
            }
            concatResult = concatResult +  " Overall Revenue: " + revenue.ToString();
            Resultlbl.Text = concatResult;
        }
    }


    class Contestant
    {
        public static char[] talentCodes = { 'S', 'D', 'M', 'O' };
        public static string[] talentStrings = {"Singing", "Dancing",
           "Musical instrument", "Other"};
        public string Name { get; set; }
        private char talentCode;
        private string talent;
        public char TalentCode
        {
            get
            {
                return talentCode;
            }
            set
            {
                int pos = talentCodes.Length;
                for (int x = 0; x < talentCodes.Length; ++x)
                    if (value == talentCodes[x])
                        pos = x;
                if (pos == talentCodes.Length)
                {
                    talentCode = 'I';
                    talent = "Invalid";
                }
                else
                {
                    talentCode = value;
                    talent = talentStrings[pos];
                }
            }

        }
        public string Talent
        {
            get
            {
                return talent;
            }
        }
        public int Fee { get; set; }
    }

    class AdultContestant : Contestant
    {
        public int ADULT_FEE = 30;
        public AdultContestant()
        {
            Fee = ADULT_FEE;
        }
        public override string ToString()
        {
            return ("Adult Contestant " + Name + " " + TalentCode + "   Fee " + Fee.ToString("C"));
        }
    }
    class TeenContestant : Contestant
    {
        public int TEEN_FEE = 20;
        public TeenContestant()
        {
            Fee = TEEN_FEE;
        }
        public override string ToString()
        {
            return ("Teen Contestant " + Name + " " + TalentCode + "   Fee " + Fee.ToString("C"));
        }
    }
    class ChildContestant : Contestant
    {
        public int CHILD_FEE = 15;
        public ChildContestant()
        {
            Fee = CHILD_FEE;
        }
        public override string ToString()
        {
            return ("Child Contestant " + Name + " " + TalentCode + "   Fee " + Fee.ToString("C"));
        }
    }
}
