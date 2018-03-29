namespace PingStatusUI
{
    partial class DebugForm
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
            this.device1ReplyLabel = new System.Windows.Forms.Label();
            this.device1StatusLabel = new System.Windows.Forms.Label();
            this.device1TextBox = new System.Windows.Forms.TextBox();
            this.device1Label = new System.Windows.Forms.Label();
            this.pingTestButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // device1ReplyLabel
            // 
            this.device1ReplyLabel.AutoSize = true;
            this.device1ReplyLabel.Location = new System.Drawing.Point(269, 15);
            this.device1ReplyLabel.Name = "device1ReplyLabel";
            this.device1ReplyLabel.Size = new System.Drawing.Size(34, 13);
            this.device1ReplyLabel.TabIndex = 12;
            this.device1ReplyLabel.Text = "Reply";
            // 
            // device1StatusLabel
            // 
            this.device1StatusLabel.AutoSize = true;
            this.device1StatusLabel.Location = new System.Drawing.Point(11, 12);
            this.device1StatusLabel.Name = "device1StatusLabel";
            this.device1StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.device1StatusLabel.TabIndex = 10;
            this.device1StatusLabel.Text = "Status";
            // 
            // device1TextBox
            // 
            this.device1TextBox.Location = new System.Drawing.Point(109, 12);
            this.device1TextBox.Name = "device1TextBox";
            this.device1TextBox.Size = new System.Drawing.Size(154, 20);
            this.device1TextBox.TabIndex = 9;
            // 
            // device1Label
            // 
            this.device1Label.AutoSize = true;
            this.device1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device1Label.Location = new System.Drawing.Point(54, 12);
            this.device1Label.Name = "device1Label";
            this.device1Label.Size = new System.Drawing.Size(57, 16);
            this.device1Label.TabIndex = 8;
            this.device1Label.Text = "Device";
            // 
            // pingTestButton1
            // 
            this.pingTestButton1.Location = new System.Drawing.Point(109, 67);
            this.pingTestButton1.Name = "pingTestButton1";
            this.pingTestButton1.Size = new System.Drawing.Size(154, 61);
            this.pingTestButton1.TabIndex = 7;
            this.pingTestButton1.Text = "Test Ping";
            this.pingTestButton1.UseVisualStyleBackColor = true;
            this.pingTestButton1.Click += new System.EventHandler(this.pingTestButton1_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 155);
            this.Controls.Add(this.device1ReplyLabel);
            this.Controls.Add(this.device1StatusLabel);
            this.Controls.Add(this.device1TextBox);
            this.Controls.Add(this.device1Label);
            this.Controls.Add(this.pingTestButton1);
            this.Name = "DebugForm";
            this.Text = "Debug Form";
            this.Load += new System.EventHandler(this.DebugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label device1ReplyLabel;
        private System.Windows.Forms.Label device1StatusLabel;
        private System.Windows.Forms.TextBox device1TextBox;
        private System.Windows.Forms.Label device1Label;
        private System.Windows.Forms.Button pingTestButton1;
    }
}