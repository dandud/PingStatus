namespace PingStatusUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pingTestButton = new System.Windows.Forms.Button();
            this.device1Label = new System.Windows.Forms.Label();
            this.device1TextBox = new System.Windows.Forms.TextBox();
            this.device1StatusLabel = new System.Windows.Forms.Label();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.device1ReplyLabel = new System.Windows.Forms.Label();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pingTestButton
            // 
            this.pingTestButton.Location = new System.Drawing.Point(173, 136);
            this.pingTestButton.Name = "pingTestButton";
            this.pingTestButton.Size = new System.Drawing.Size(154, 61);
            this.pingTestButton.TabIndex = 0;
            this.pingTestButton.Text = "Test Ping";
            this.pingTestButton.UseVisualStyleBackColor = true;
            this.pingTestButton.Click += new System.EventHandler(this.pingTestButton_Click);
            // 
            // device1Label
            // 
            this.device1Label.AutoSize = true;
            this.device1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device1Label.Location = new System.Drawing.Point(69, 51);
            this.device1Label.Name = "device1Label";
            this.device1Label.Size = new System.Drawing.Size(69, 16);
            this.device1Label.TabIndex = 1;
            this.device1Label.Text = "Device 1";
            // 
            // device1TextBox
            // 
            this.device1TextBox.Location = new System.Drawing.Point(144, 51);
            this.device1TextBox.Name = "device1TextBox";
            this.device1TextBox.Size = new System.Drawing.Size(134, 20);
            this.device1TextBox.TabIndex = 2;
            // 
            // device1StatusLabel
            // 
            this.device1StatusLabel.AutoSize = true;
            this.device1StatusLabel.Location = new System.Drawing.Point(26, 51);
            this.device1StatusLabel.Name = "device1StatusLabel";
            this.device1StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.device1StatusLabel.TabIndex = 3;
            this.device1StatusLabel.Text = "Status";
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(514, 24);
            this.mainFormMenuStrip.TabIndex = 4;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 144);
            this.dataGridView1.TabIndex = 5;
            // 
            // device1ReplyLabel
            // 
            this.device1ReplyLabel.AutoSize = true;
            this.device1ReplyLabel.Location = new System.Drawing.Point(284, 54);
            this.device1ReplyLabel.Name = "device1ReplyLabel";
            this.device1ReplyLabel.Size = new System.Drawing.Size(34, 13);
            this.device1ReplyLabel.TabIndex = 6;
            this.device1ReplyLabel.Text = "Reply";
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "notifyIcon1";
            this.appNotifyIcon.Visible = true;
            this.appNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.appNotifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 382);
            this.Controls.Add(this.device1ReplyLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.device1StatusLabel);
            this.Controls.Add(this.device1TextBox);
            this.Controls.Add(this.device1Label);
            this.Controls.Add(this.pingTestButton);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Ping Status";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pingTestButton;
        private System.Windows.Forms.Label device1Label;
        private System.Windows.Forms.TextBox device1TextBox;
        private System.Windows.Forms.Label device1StatusLabel;
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label device1ReplyLabel;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
    }
}

