using System;
using System.Windows.Forms;

namespace CSC3220_HW1
{
    public partial class SupremeFoods : Form
    {
        public SupremeFoods()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void soup_Click(object sender, EventArgs e)
        {
            //Soup
            soupName.Visible = true;
            pictureSoup.Visible = true;
            SoupDescrip.Visible = true;
            SoupPrice.Visible = true;

            //Cheif Special
            ChefSpeicalPic.Visible = false;
            ChefSpecialName.Visible = false;
            ChefPrice.Visible = false;
            ChefDescrip.Visible = false;

            //Burgur
            BurgurPicture.Visible = false;
            BurgurName.Visible = false;
            burgurPrice.Visible = false;
            burgurDescrip.Visible = false;

            //welcome
            Welcome.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChefSpecial_Click(object sender, EventArgs e)
        {
            //Chef Speical
            ChefSpeicalPic.Visible = true;
            ChefSpecialName.Visible = true;
            ChefPrice.Visible = true;
            ChefDescrip.Visible = true;

            //soup
            soupName.Visible = false;
            pictureSoup.Visible = false;
            SoupDescrip.Visible = false;
            SoupPrice.Visible = false;

            //Burgur
            BurgurPicture.Visible = false;
            BurgurName.Visible = false;
            burgurPrice.Visible = false;
            burgurDescrip.Visible = false;

            //welcome
            Welcome.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ChefSpecialName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Burgur
            BurgurPicture.Visible = true;
            BurgurName.Visible = true;
            burgurPrice.Visible = true;
            burgurDescrip.Visible = true;

            //soup
            soupName.Visible = false;
            pictureSoup.Visible = false;
            SoupDescrip.Visible = false;
            SoupPrice.Visible = false;

            //Cheif Special
            ChefSpeicalPic.Visible = false;
            ChefSpecialName.Visible = false;
            ChefPrice.Visible = false;
            ChefDescrip.Visible = false;

            //welcome
            Welcome.Visible = false;

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void BurgurName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void SupremeFoods_Load(object sender, EventArgs e)
        {

        }

        private void ChefDescrip_Click(object sender, EventArgs e)
        {

        }
    }
}
