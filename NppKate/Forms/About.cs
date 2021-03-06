// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
/*
Copyright (c) 2015-2016, Schadin Alexey (schadin@gmail.com)
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted 
provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this list of conditions 
and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions 
and the following disclaimer in the documentation and/or other materials provided with 
the distribution.

3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse 
or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR 
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND 
FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF 
THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Windows.Forms;

namespace NppKate.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lPluginName.Text = Properties.Resources.PluginName;
            var version = this.GetType().Assembly.GetName().Version;
            lVersion.Text = $"v{version.Major}.{version.Minor}.{version.Build} build {version.Revision}";
            tbLicense.Text = Properties.Resources.LICENSE;
        }

        private void llMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llMail.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:" + llMail.Text + "?subject=NppKate");
        }

        private void llIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llIssue.LinkVisited = true;
            System.Diagnostics.Process.Start("https://nppgit.myjetbrains.com/youtrack/issues");

        }

        private void llYusuke_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llYusuke.LinkVisited = true;
            System.Diagnostics.Process.Start("http://p.yusukekamiyamane.com/");
        }

        private void llCCA30L_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llCCA30L.LinkVisited = true;
            System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by/3.0/");
        }

        private void llBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llBoard.LinkVisited = true;
            System.Diagnostics.Process.Start("https://nppgit.myjetbrains.com/youtrack/rest/agile");
        }

        private void llWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llWiki.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/schadin/NppKate/wiki");
        }

        private void lChangelog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lChangelog.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/schadin/NppKate/wiki/%233-Changelog");
        }
    }
}
