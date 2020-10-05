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
            this.phantom_connections_panel = new System.Windows.Forms.Panel();
            this.open_create_new_connection_panel_button = new System.Windows.Forms.Button();
            this.create_new_connection_panel = new System.Windows.Forms.Panel();
            this.close_create_new_connection_panel_button = new System.Windows.Forms.Button();
            this.create_new_connection_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.create_new_connection_workers_textbox = new System.Windows.Forms.TextBox();
            this.create_new_connection_port_textbox = new System.Windows.Forms.TextBox();
            this.create_new_connection_host_textbox = new System.Windows.Forms.TextBox();
            this.create_new_connection_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // phantom_connections_panel
            // 
            this.phantom_connections_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phantom_connections_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.phantom_connections_panel.Location = new System.Drawing.Point(0, 0);
            this.phantom_connections_panel.Name = "phantom_connections_panel";
            this.phantom_connections_panel.Size = new System.Drawing.Size(200, 458);
            this.phantom_connections_panel.TabIndex = 4;
            // 
            // open_create_new_connection_panel_button
            // 
            this.open_create_new_connection_panel_button.Location = new System.Drawing.Point(497, 12);
            this.open_create_new_connection_panel_button.Name = "open_create_new_connection_panel_button";
            this.open_create_new_connection_panel_button.Size = new System.Drawing.Size(193, 33);
            this.open_create_new_connection_panel_button.TabIndex = 5;
            this.open_create_new_connection_panel_button.Text = "Create New Connection";
            this.open_create_new_connection_panel_button.UseVisualStyleBackColor = true;
            this.open_create_new_connection_panel_button.Click += new System.EventHandler(this.open_create_connection_panel_button_Click);
            // 
            // create_new_connection_panel
            // 
            this.create_new_connection_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_new_connection_panel.Controls.Add(this.close_create_new_connection_panel_button);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_button);
            this.create_new_connection_panel.Controls.Add(this.label6);
            this.create_new_connection_panel.Controls.Add(this.label5);
            this.create_new_connection_panel.Controls.Add(this.label4);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_workers_textbox);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_port_textbox);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_host_textbox);
            this.create_new_connection_panel.Location = new System.Drawing.Point(233, 121);
            this.create_new_connection_panel.Name = "create_new_connection_panel";
            this.create_new_connection_panel.Size = new System.Drawing.Size(270, 183);
            this.create_new_connection_panel.TabIndex = 6;
            this.create_new_connection_panel.Visible = false;
            // 
            // close_create_new_connection_panel_button
            // 
            this.close_create_new_connection_panel_button.FlatAppearance.BorderSize = 0;
            this.close_create_new_connection_panel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_create_new_connection_panel_button.Location = new System.Drawing.Point(240, 2);
            this.close_create_new_connection_panel_button.Name = "close_create_new_connection_panel_button";
            this.close_create_new_connection_panel_button.Size = new System.Drawing.Size(29, 23);
            this.close_create_new_connection_panel_button.TabIndex = 7;
            this.close_create_new_connection_panel_button.Text = "X";
            this.close_create_new_connection_panel_button.UseMnemonic = false;
            this.close_create_new_connection_panel_button.UseVisualStyleBackColor = true;
            this.close_create_new_connection_panel_button.Click += new System.EventHandler(this.close_create_connection_panel_button_Click);
            // 
            // create_new_connection_button
            // 
            this.create_new_connection_button.Location = new System.Drawing.Point(93, 139);
            this.create_new_connection_button.Name = "create_new_connection_button";
            this.create_new_connection_button.Size = new System.Drawing.Size(75, 23);
            this.create_new_connection_button.TabIndex = 6;
            this.create_new_connection_button.Text = "Create";
            this.create_new_connection_button.UseVisualStyleBackColor = true;
            this.create_new_connection_button.Click += new System.EventHandler(this.create_new_connection_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Workers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Create New Connection";
            // 
            // create_new_connection_workers_textbox
            // 
            this.create_new_connection_workers_textbox.Location = new System.Drawing.Point(58, 92);
            this.create_new_connection_workers_textbox.Name = "create_new_connection_workers_textbox";
            this.create_new_connection_workers_textbox.Size = new System.Drawing.Size(100, 20);
            this.create_new_connection_workers_textbox.TabIndex = 2;
            this.create_new_connection_workers_textbox.Text = "1";
            // 
            // create_new_connection_port_textbox
            // 
            this.create_new_connection_port_textbox.Location = new System.Drawing.Point(164, 52);
            this.create_new_connection_port_textbox.Name = "create_new_connection_port_textbox";
            this.create_new_connection_port_textbox.Size = new System.Drawing.Size(100, 20);
            this.create_new_connection_port_textbox.TabIndex = 1;
            this.create_new_connection_port_textbox.Text = "19132";
            // 
            // create_new_connection_host_textbox
            // 
            this.create_new_connection_host_textbox.Location = new System.Drawing.Point(58, 52);
            this.create_new_connection_host_textbox.Name = "create_new_connection_host_textbox";
            this.create_new_connection_host_textbox.Size = new System.Drawing.Size(100, 20);
            this.create_new_connection_host_textbox.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 458);
            this.Controls.Add(this.create_new_connection_panel);
            this.Controls.Add(this.open_create_new_connection_panel_button);
            this.Controls.Add(this.phantom_connections_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "PhantomGUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Main_ClientSizeChanged);
            this.create_new_connection_panel.ResumeLayout(false);
            this.create_new_connection_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel phantom_connections_panel;
        private System.Windows.Forms.Button open_create_new_connection_panel_button;
        private System.Windows.Forms.Panel create_new_connection_panel;
        private System.Windows.Forms.Button create_new_connection_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox create_new_connection_workers_textbox;
        private System.Windows.Forms.TextBox create_new_connection_port_textbox;
        private System.Windows.Forms.TextBox create_new_connection_host_textbox;
        private System.Windows.Forms.Button close_create_new_connection_panel_button;
    }
}

