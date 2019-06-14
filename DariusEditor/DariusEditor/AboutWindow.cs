using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariusEditor
{
    public partial class AboutWindow : Form
    {
        private MainEditorWindow editor;

        public AboutWindow(MainEditorWindow associated_editor)
        {
            InitializeComponent();
            editor = associated_editor;
        }



        private void OpenURL(string url)
        {
            System.Diagnostics.Process.Start(url);
        }



        private void AboutWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            editor.Enabled = true;
        }



        private void aboutLinkNotEd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL("www.not-ed.com");
        }



        private void aboutLinkGithubNotEd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL("www.github.com/not-ed");
        }



        private void aboutLinkYoutube3Kliksphilip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL("www.youtube.com/3kliksphilip");
        }



        private void aboutLink3kliksphilip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL("www.3kliksphilip.com");
        }
    }
}
