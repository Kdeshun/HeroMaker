using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HeroMaker1
{
    public partial class Form1 : Form
    {
        string logo_symbol = "";


        public Form1()
        {
            InitializeComponent();

        }


        public void btnCreateHero_Click(object sender, EventArgs e)
        {
            string heroName = txtHeroName.Text;
            bool[] abilities = { false, false, false, false, false, false, false, false };

            List<String> cities = new List<String>();
            foreach (String s in lst_Cities.SelectedItems)
            {
                cities.Add(s);
            }

            string sidekick = "";

            int speed = scrlSpeed.Value, stamina = scrlStamina.Value, strength = scrlStrength.Value;

            decimal YearsExp = numExperience.Value;

            abilities[0] = chkbxFly.Checked;
            abilities[1] = chkbxMindControl.Checked;
            abilities[2] = chkbxSuperSmart.Checked;
            abilities[3] = chkbxSuperSpeed.Checked;
            abilities[4] = chkbxSuperStrength.Checked;
            abilities[5] = chkbxSuperRich.Checked;
            abilities[6] = chkbxInvisibility.Checked;
            abilities[7] = chkbxShapeShift.Checked;

            DateTime Birthday = dtBirth.Value;
            DateTime Discover = dtDiscovery.Value;
            DateTime Reveal = dtReveal.Value;
            int date1 = DateTime.Compare(Birthday, Discover);
            int date2 = DateTime.Compare(Discover, Reveal);
            int evil = trckbrEvil.Value;




            if (rbSuperAnimal.Checked)
            {
                sidekick = "Harry the Super Hamster";
            }
            if (rbTeen.Checked)
            {
                sidekick = "Duck Boy";
            }
            if (rbRobot.Checked)
            {
                sidekick = "iThink therefor iAm 2.0";
            }

            string status_Message = "Your Hero '" + txtHeroName.Text + "', can: ";
            if (abilities[0])
                status_Message += "fly, ";
            if (abilities[1])
                status_Message += "control minds, ";
            if (abilities[2])
                status_Message += "mentally compute anything, ";
            if (abilities[3])
                status_Message += "run fast, ";
            if (abilities[4])
                status_Message += "lift impossibly heavy objects, ";
            if (abilities[5])
                status_Message += "buy anything, ";
            if (abilities[6])
                status_Message += "turn invisible, ";
            if (abilities[7])
                status_Message += "shape shift, ";

            status_Message += "and thats it. They work in: ";
            foreach (String city in cities)
            {
                status_Message += city + ", and ";
            }

            status_Message += "work with their trusty sidekick: " + sidekick + ".";

            status_Message += "\nThey have Strength: " + strength + ". Speed: " + speed + ". Stamina: " + stamina + ". ";
            status_Message += "\nThe day that " + heroName + " was born is: " + Birthday + ". They discovered their abilities on: " + Discover + ". They revealed themself to the rest of the world: " + Reveal + ". ";
            status_Message += "\nThey have " + YearsExp + " years experience";
            status_Message += "\nThe cape color they have is: " + pbCapeColor;
            status_Message += "\n" + heroName + " has: " + evil + " capacity for Evil.";
            status_Message += "\nThe logo they have is: " + logo_symbol;



            if (heroName == "")
            {
                status_Message = "Please give your hero a name before continuing.";

            }
            else if (speed + stamina + strength > 150)
            {
                status_Message = "You cannot have more than 150 Total points for Strength, Speed, and Stamina";

            }

            else if (date1 > 0)

            {
                status_Message = "A hero cannot discover their abilities before they are born.";

            }

            else if (date2 > 0)
            {
                status_Message = "A hero cannot reveal their abilities before they are discover them.";

            }
            else
            {
                Hero hero = new Hero(heroName, abilities, cities, sidekick, strength, speed, stamina, Birthday, Discover, Reveal, YearsExp, pbCapeColor.ToString(), evil, logo_symbol);


                HeroList.hallOfHeros.Add(hero);
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }


            MessageBox.Show(status_Message);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void scrlStrength_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrlSpeed.Value + scrlStamina.Value + scrlStrength.Value > 150)
            {
                groupBox2.BackColor = Color.Red;
            }
            else
            {
                groupBox2.BackColor = default;
            }
            lblStrength.Text = scrlStrength.Value.ToString();
        }

        private void scrlSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrlSpeed.Value + scrlStamina.Value + scrlStrength.Value > 150)
            {
                groupBox2.BackColor = Color.Red;
            }
            else
            {
                groupBox2.BackColor = default;
            }
            lblSpeed.Text = scrlSpeed.Value.ToString();
        }

        private void scrlStamina_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrlSpeed.Value + scrlStamina.Value + scrlStrength.Value > 150)
            {
                groupBox2.BackColor = Color.Red;
            }
            else
            {
                groupBox2.BackColor = default;
            }
            lblStamina.Text = scrlStamina.Value.ToString();
        }

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtDiscovery_ValueChanged(object sender, EventArgs e)
        {
            DateTime Birthday = dtBirth.Value;
            DateTime Discover = dtDiscovery.Value;
            DateTime Reveal = dtReveal.Value;
            int date1 = DateTime.Compare(Birthday, Discover);
            int date2 = DateTime.Compare(Discover, Reveal);

            if (date1 > 0)
                groupBox3.BackColor = Color.Red;
            else
                groupBox3.BackColor = default;
        }

        private void dtReveal_ValueChanged(object sender, EventArgs e)
        {
            DateTime Birthday = dtBirth.Value;
            DateTime Discover = dtDiscovery.Value;
            DateTime Reveal = dtReveal.Value;
            int date1 = DateTime.Compare(Birthday, Discover);
            int date2 = DateTime.Compare(Discover, Reveal);

            if (date2 > 0)
                groupBox3.BackColor = Color.Red;
            else
                groupBox3.BackColor = default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                pbCapeColor.BackColor = color.Color;
            }
        }

        private void trckbrEvil_Scroll(object sender, EventArgs e)
        {
            lblEvil.Text = trckbrEvil.Value.ToString();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog logo = new OpenFileDialog();
            if (logo.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = new Bitmap(logo.FileName);

                logo_symbol = logo.FileName;
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            ListofHeros loh = new ListofHeros();
            loh.Show();

        }
    }
}
