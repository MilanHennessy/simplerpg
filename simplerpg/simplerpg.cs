using System;
using System.Windows.Forms;
using Engine;

namespace simplerpg
{
    public partial class simplerpg : Form
    {
        private Player _player;
        public simplerpg()
        {
            InitializeComponent();

            _player = new Player(20,0,1,10,10);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            Location location = new Location(1, "Home", "This is your home");

        }

        private void simplerpg_Load(object sender, EventArgs e)
        {

        }


    }
}
