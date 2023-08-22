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
using static System.Net.Mime.MediaTypeNames;

namespace Learning4
{
    public partial class Form1 : Form
    {
        Random rand;
        String currentDir;
        System.Diagnostics.Process proc;
        static string currPlan = "";

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            currentDir = Directory.GetCurrentDirectory();

            // Minimize form on startup and display on system tray
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            powerPlanIcon.Icon = SystemIcons.Application;

            proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "checkPlan.vbs";
            proc.StartInfo.WorkingDirectory = currentDir + "\\power";
            proc.Start();
            proc.WaitForExit();

            string text = File.ReadAllText(currentDir + "\\power\\plan.txt");
            int start = text.IndexOf("(") + 1;
            int length = text.IndexOf(")") - start;
            currPlan = text.Substring(start, length);

            powerPlanIcon.ContextMenuStrip = contextMenu;
            powerPlanIcon.Icon = SystemIcons.Application;

            System.Diagnostics.Debug.WriteLine(currPlan);
            update();
            powerPlanIcon.Visible = true;
        }

        private byte[] GetRandomBytes(int n)
        {
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void update()
        {
            if (currPlan.Equals("High performance"))
            {
                powerPlanIcon.Icon = Properties.Resources.red;
            }
            else if (currPlan.Equals("Balanced"))
            {
                powerPlanIcon.Icon = Properties.Resources.orange;
            }
            else
            {
                powerPlanIcon.Icon = Properties.Resources.green;
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
                this.ShowInTaskbar = false;
                powerPlanIcon.Visible = true;
            }
        }

        private void powerPlanIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                powerPlanIcon.Visible = false;
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
                proc.WaitForExit();
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
                proc.WaitForExit();
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
                proc.WaitForExit();
                currPlan = "High performance";
                update();
            }
        }
    }
}
