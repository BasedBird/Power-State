using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning4
{
    public partial class Form1 : Form
    {
        Random rand;
        String currentDir;
        System.Diagnostics.Process proc;
        static string currPlan = "";
        static string prevPlan = "";

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            notifyIcon1.ContextMenuStrip = contextMenu;
            currentDir = Directory.GetCurrentDirectory();

            // Minimize form on startup and displayer on system tray
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Icon = SystemIcons.Application;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;

            proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "checkPlan.vbs";
            proc.StartInfo.WorkingDirectory = currentDir + "\\power";
            proc.Start();

            System.Threading.Thread.Sleep(1000);

            string text = File.ReadAllText(currentDir + "\\power\\plan.txt");
            text = text.Substring(text.IndexOf("(") + 1);
            text = text.Remove(text.IndexOf(")"));
            currPlan = text;
            update();

        }

        private byte[] GetRandomBytes(int n)
        {
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void update()
        {

            if (currPlan.Equals(prevPlan)) { }
            else if (currPlan.Equals("High performance"))
            {
                notifyIcon1.Icon = Properties.Resources.red;
                prevPlan = "High performance";
            }
            else if (currPlan.Equals("Balanced"))
            {
                notifyIcon1.Icon = Properties.Resources.orange;
                prevPlan = "Balanced";
            }
            else
            {
                notifyIcon1.Icon = Properties.Resources.green;
                prevPlan = "Power saver";
            }
        }

        private void changeColour_Click(object sender, EventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);
            hello.ForeColor = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool MousePointerNotOnTaskBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskBar)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void tsExit_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Close();
            }
        }

        private void save_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                proc.StartInfo.FileName = "setPowerSaver.vbs";
                proc.StartInfo.WorkingDirectory = currentDir + "\\power";
                proc.Start();
                currPlan = "Power saver";
                update();
            }
        }

        private void tsBal_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                proc.StartInfo.FileName = "setBalanced.vbs";
                proc.StartInfo.WorkingDirectory = currentDir + "\\power";
                proc.Start();
                currPlan = "Balanced";
                update();
            }
        }

        private void tsHigh_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                proc.StartInfo.FileName = "setHighPerformance.vbs";
                proc.StartInfo.WorkingDirectory = currentDir + "\\power";
                proc.Start();
                currPlan = "High performance";
                update();
            }
        }
    }
}
