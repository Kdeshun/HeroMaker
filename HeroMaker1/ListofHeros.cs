using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker1
{

    public partial class ListofHeros : Form
    {
        public int a = 0;
        BindingSource bs = new BindingSource();
        public ListofHeros()
        {
            InitializeComponent();

            bs.DataSource = HeroList.hallOfHeros;
            lbListofHeros.DataSource = bs;
            lbListofHeros.DisplayMember = "Name";
        }

        private void ListofHeros_Load(object sender, EventArgs e)
        {

        }

        private void lbListofHeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbListofHeros.Text = lbListofHeros.SelectedItem.ToString();
            }
            catch
            {
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {


            if (a % 2 == 0)
            {
                HeroList.hallOfHeros.Sort();


                bs.ResetBindings(false);
            }
            else
            {
                HeroList.hallOfHeros.Sort();
                HeroList.hallOfHeros.Reverse();

                bs.ResetBindings(false);
            }
            a++;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HeroList.hallOfHeros.Remove((Hero)lbListofHeros.SelectedItem);
            bs.ResetBindings(false);
        }
    }
}