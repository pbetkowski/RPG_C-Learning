using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;


namespace RPGame
{
    public partial class Scene : Form
    {
        private Player player;

        public Scene()
        {
            InitializeComponent();
            player = new Player(20, 0, 1, 10, 10);
          

            Location location = new Location(1, "Training Hall", "This is your second home");


            lbHP.Text = player.CurrentHitPoints.ToString();
            lbGold.Text = player.Gold.ToString();
            lbEXP.Text = player.ExperiencePoints.ToString();
            lbLevel.Text = player.Level.ToString();

         
        }

      

        private void Scene_Load(object sender, EventArgs e)
        {

        }
    }
}
