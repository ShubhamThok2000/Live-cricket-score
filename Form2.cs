using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // initilatiasion for sliding panel 
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //sliding panel code
        bool isSlidingPanelExpanded;
        const int maxsliderwidth = 166;
        const int minsliderwidth = 60;

        private void button1_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                retractSlidingPanelGUI();
            }
            SlidingPanelTimer.Start();
        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //retract
                SlidingPanel.Width -= 30;
                if(SlidingPanel.Width <= minsliderwidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    SlidingPanelTimer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= maxsliderwidth)
                {
                    //stop expanding
                    isSlidingPanelExpanded = true;
                    SlidingPanelTimer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }

        public void expandSlidingPanelGUI()
        {
            //gui for expand
            TeamResistrasion.Text = "Registrasion";
            Teams.Text = "Team";
            Tournaments.Text = "Tournaments";
            User.Text = "User";
            About.Text = "About";
            button1.Text = "HOME";

            TeamResistrasion.Image = null;
            Teams.Image = null;
            Tournaments.Image = null;
            User.Image = null;
            About.Image = null;
            button1.Image = null;
        }

        public void retractSlidingPanelGUI()
        {
            //gui for retract
            TeamResistrasion.Text = "";
            Teams.Text = "";
            Tournaments.Text = "";
            User.Text = "";
            About.Text = "";
            button1.Text = "";

            TeamResistrasion.Image = Properties.Resources.registration;
            Teams.Image = Properties.Resources.team;
            Tournaments.Image = Properties.Resources.vs;
            User.Image = Properties.Resources.user;
            About.Image = Properties.Resources.about;
            button1.Image = Properties.Resources.arrow;
        }
    }
}
