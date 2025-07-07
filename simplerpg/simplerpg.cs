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

            _player = new Player();
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.gold = 20;
            _player.ExperiencePoints = 10;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void simplerpg_Load(object sender, EventArgs e)
        {

        }


    }
}
