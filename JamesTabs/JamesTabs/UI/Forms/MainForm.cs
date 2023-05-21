using JamesTabs.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesTabs.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnJamesTodo_Click(object sender, EventArgs e)
        {
            if (pnlContant.Controls.Contains(JamesTodo.Instance) == false)
            {
                pnlContant.Controls.Add(JamesTodo.Instance);
                JamesTodo.Instance.Dock = DockStyle.Fill;
                JamesTodo.Instance.BringToFront();
            }
            else
            {
                JamesTodo.Instance.BringToFront();
            }
        }

        private void btnJamesTodo2_Click(object sender, EventArgs e)
        {
            if (pnlContant.Controls.Contains(Accounts.Instance) == false)
            {
                pnlContant.Controls.Add(Accounts.Instance);
                Accounts.Instance.Dock = DockStyle.Fill;
                Accounts.Instance.BringToFront();
            }
            else
            {
                Accounts.Instance.BringToFront();
            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

		private void btnYoutubeVideoPlayer_Click(object sender, EventArgs e)
		{
			if (pnlContant.Controls.Contains(YoutubeViedoPlayer.Instance) == false)
			{
				pnlContant.Controls.Add(YoutubeViedoPlayer.Instance);
				YoutubeViedoPlayer.Instance.Dock = DockStyle.Fill;
				YoutubeViedoPlayer.Instance.BringToFront();
			}
			else
			{
				YoutubeViedoPlayer.Instance.BringToFront();
			}
		}
	}
}
