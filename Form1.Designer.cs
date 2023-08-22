namespace Learning4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.changeColour = new System.Windows.Forms.Button();
            this.hello = new System.Windows.Forms.TextBox();
            this.powerPlanIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBal = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeColour
            // 
            this.changeColour.Location = new System.Drawing.Point(335, 272);
            this.changeColour.Name = "changeColour";
            this.changeColour.Size = new System.Drawing.Size(140, 23);
            this.changeColour.TabIndex = 0;
            this.changeColour.Text = "Change Colour";
            this.changeColour.UseVisualStyleBackColor = true;
            this.changeColour.Click += new System.EventHandler(this.changeColour_Click);
            // 
            // hello
            // 
            this.hello.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.Location = new System.Drawing.Point(238, 140);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(350, 84);
            this.hello.TabIndex = 1;
            this.hello.Text = "Hello World";
            this.hello.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // powerPlanIcon
            // 
            this.powerPlanIcon.Text = "PowerPlan";
            //this.powerPlanIcon.Visible = true;
            this.powerPlanIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.powerPlanIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHigh,
            this.tsBal,
            this.tsSave,
            this.tsExit});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // tsSave
            // 
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(180, 22);
            this.tsSave.Text = "Power Saver";
            this.tsSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.save_MouseUp);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(180, 22);
            this.tsExit.Text = "Exit";
            this.tsExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsExit_MouseUp);
            // 
            // tsHigh
            // 
            this.tsHigh.Name = "tsHigh";
            this.tsHigh.Size = new System.Drawing.Size(180, 22);
            this.tsHigh.Text = "High Performance";
            this.tsHigh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsHigh_MouseUp);
            // 
            // tsBal
            // 
            this.tsBal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBal.Name = "tsBal";
            this.tsBal.Size = new System.Drawing.Size(180, 22);
            this.tsBal.Text = "Balanced ";
            this.tsBal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsBal_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.changeColour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeColour;
        private System.Windows.Forms.TextBox hello;
        private System.Windows.Forms.NotifyIcon powerPlanIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsHigh;
        private System.Windows.Forms.ToolStripMenuItem tsBal;
    }
}

