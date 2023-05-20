using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesTabs.UI.Forms
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent(); 
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbUrl.Text))
			{
				try
				{
					PlayVideo(tbUrl.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void PlayVideo(string url)
		{
			try
			{
				string html = "<html><head>";
				html += "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>";
				html += "<iframe src='https://www.youtube.com/embed/{0}' width='600' height='400' frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>";
				html += "</body></html>";
				this.webBrowser.DocumentText = string.Format(html, url.Split('=')[1]);
			}
			catch (Exception)
			{
				throw new Exception("Invalid Youtube URL provided, Please check your URL and enter it again.");
			}
		}
	}
}
