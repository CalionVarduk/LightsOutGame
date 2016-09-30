using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOutGame
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            try { Icon = new System.Drawing.Icon("..\\..\\Bulb.ico"); } catch (Exception) { }

            TitleLabel.Top = 12;
            AuthorLabel.Top = TitleLabel.Bottom;
            InfoLabel.Top = AuthorLabel.Bottom + 12;
            GitHubLabel.Top = InfoLabel.Bottom - 1;

            ClientSize = new Size(InfoLabel.Right + 12, GitHubLabel.Bottom + 12);

            int hWidth = ClientSize.Width >> 1;
            TitleLabel.Left = hWidth - (TitleLabel.Width >> 1);
            AuthorLabel.Left = hWidth - (AuthorLabel.Width >> 1);
            GitHubLabel.Left = InfoLabel.Left;

            InfoLabel.Links.Add(0, 10, "https://en.wikipedia.org/wiki/Lights_Out_(game)");
            GitHubLabel.Links.Add(0, GitHubLabel.Text.Length, "https://github.com/CalionVarduk");
        }

        private void Event_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
