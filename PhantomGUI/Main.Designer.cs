namespace PhantomGUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.start_phantom_btn = new System.Windows.Forms.Button();
            this.hostname_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.worker_textbox = new System.Windows.Forms.TextBox();
            this.stop_phantom_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_phantom_btn
            // 
            this.start_phantom_btn.Location = new System.Drawing.Point(80, 106);
            this.start_phantom_btn.Name = "start_phantom_btn";
            this.start_phantom_btn.Size = new System.Drawing.Size(75, 23);
            this.start_phantom_btn.TabIndex = 0;
            this.start_phantom_btn.Text = "Start";
            this.start_phantom_btn.UseVisualStyleBackColor = true;
            this.start_phantom_btn.Click += new System.EventHandler(this.start_phantom_btn_Click);
            // 
            // hostname_textbox
            // 
            this.hostname_textbox.Location = new System.Drawing.Point(24, 35);
            this.hostname_textbox.Name = "hostname_textbox";
            this.hostname_textbox.Size = new System.Drawing.Size(100, 20);
            this.hostname_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Host";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.worker_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.port_textbox);
            this.panel1.Controls.Add(this.hostname_textbox);
            this.panel1.Controls.Add(this.start_phantom_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stop_phantom_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 143);
            this.panel1.TabIndex = 3;
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(130, 35);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(69, 20);
            this.port_textbox.TabIndex = 3;
            this.port_textbox.Text = "19132";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Workers";
            // 
            // worker_textbox
            // 
            this.worker_textbox.Location = new System.Drawing.Point(80, 71);
            this.worker_textbox.Name = "worker_textbox";
            this.worker_textbox.Size = new System.Drawing.Size(100, 20);
            this.worker_textbox.TabIndex = 6;
            this.worker_textbox.Text = "1";
            // 
            // stop_phantom_btn
            // 
            this.stop_phantom_btn.Location = new System.Drawing.Point(80, 106);
            this.stop_phantom_btn.Name = "stop_phantom_btn";
            this.stop_phantom_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_phantom_btn.TabIndex = 7;
            this.stop_phantom_btn.Text = "Stop";
            this.stop_phantom_btn.UseVisualStyleBackColor = true;
            this.stop_phantom_btn.Click += new System.EventHandler(this.stop_phantom_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 167);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "PhantomGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_phantom_btn;
        private System.Windows.Forms.TextBox hostname_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox worker_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.Button stop_phantom_btn;
    }
}

