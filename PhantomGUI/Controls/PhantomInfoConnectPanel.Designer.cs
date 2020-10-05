namespace PhantomGUI.Controls
{
    partial class PhantomInfoConnectPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_btn = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.stop_instance_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.Color.Transparent;
            this.connect_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.Location = new System.Drawing.Point(0, 0);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(194, 70);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "SurviveCraft";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackgroundImage = global::PhantomGUI.Properties.Resources.trashcan_icon;
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_button.Location = new System.Drawing.Point(151, 21);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(40, 33);
            this.delete_button.TabIndex = 1;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // stop_instance_button
            // 
            this.stop_instance_button.Location = new System.Drawing.Point(58, 44);
            this.stop_instance_button.Name = "stop_instance_button";
            this.stop_instance_button.Size = new System.Drawing.Size(75, 23);
            this.stop_instance_button.TabIndex = 2;
            this.stop_instance_button.Text = "Stop";
            this.stop_instance_button.UseVisualStyleBackColor = true;
            this.stop_instance_button.Visible = false;
            this.stop_instance_button.Click += new System.EventHandler(this.stop_instance_button_Click);
            // 
            // PhantomInfoConnectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stop_instance_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.connect_btn);
            this.Name = "PhantomInfoConnectPanel";
            this.Size = new System.Drawing.Size(194, 70);
            this.Load += new System.EventHandler(this.PhantomInfoConnectPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button stop_instance_button;
    }
}
