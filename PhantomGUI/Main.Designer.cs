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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.create_new_connection_binding_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.create_new_connection_binding_port_textbox = new System.Windows.Forms.TextBox();
            this.create_new_connection_debug_checkbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.create_new_connection_timeout_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.create_new_connection_ipv6_checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.create_new_connection_remove_ports_checkbox = new System.Windows.Forms.CheckBox();
            this.create_new_connection_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // phantom_connections_panel
            // 
            this.phantom_connections_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phantom_connections_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.phantom_connections_panel.Location = new System.Drawing.Point(0, 0);
            this.phantom_connections_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phantom_connections_panel.Name = "phantom_connections_panel";
            this.phantom_connections_panel.Size = new System.Drawing.Size(300, 705);
            this.phantom_connections_panel.TabIndex = 4;
            // 
            // open_create_new_connection_panel_button
            // 
            this.open_create_new_connection_panel_button.Location = new System.Drawing.Point(749, 18);
            this.open_create_new_connection_panel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.open_create_new_connection_panel_button.Name = "open_create_new_connection_panel_button";
            this.open_create_new_connection_panel_button.Size = new System.Drawing.Size(290, 51);
            this.open_create_new_connection_panel_button.TabIndex = 5;
            this.open_create_new_connection_panel_button.Text = "Create New Connection";
            this.open_create_new_connection_panel_button.UseVisualStyleBackColor = true;
            this.open_create_new_connection_panel_button.Click += new System.EventHandler(this.open_create_connection_panel_button_Click);
            // 
            // create_new_connection_panel
            // 
            this.create_new_connection_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_new_connection_panel.Controls.Add(this.groupBox1);
            this.create_new_connection_panel.Controls.Add(this.close_create_new_connection_panel_button);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_button);
            this.create_new_connection_panel.Controls.Add(this.label6);
            this.create_new_connection_panel.Controls.Add(this.label5);
            this.create_new_connection_panel.Controls.Add(this.label4);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_workers_textbox);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_port_textbox);
            this.create_new_connection_panel.Controls.Add(this.create_new_connection_host_textbox);
            this.create_new_connection_panel.Location = new System.Drawing.Point(360, 121);
            this.create_new_connection_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_panel.Name = "create_new_connection_panel";
            this.create_new_connection_panel.Size = new System.Drawing.Size(583, 508);
            this.create_new_connection_panel.TabIndex = 6;
            this.create_new_connection_panel.Visible = false;
            // 
            // close_create_new_connection_panel_button
            // 
            this.close_create_new_connection_panel_button.FlatAppearance.BorderSize = 0;
            this.close_create_new_connection_panel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_create_new_connection_panel_button.Location = new System.Drawing.Point(360, 3);
            this.close_create_new_connection_panel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_create_new_connection_panel_button.Name = "close_create_new_connection_panel_button";
            this.close_create_new_connection_panel_button.Size = new System.Drawing.Size(44, 35);
            this.close_create_new_connection_panel_button.TabIndex = 7;
            this.close_create_new_connection_panel_button.Text = "X";
            this.close_create_new_connection_panel_button.UseMnemonic = false;
            this.close_create_new_connection_panel_button.UseVisualStyleBackColor = true;
            this.close_create_new_connection_panel_button.Click += new System.EventHandler(this.close_create_connection_panel_button_Click);
            // 
            // create_new_connection_button
            // 
            this.create_new_connection_button.Location = new System.Drawing.Point(222, 454);
            this.create_new_connection_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_button.Name = "create_new_connection_button";
            this.create_new_connection_button.Size = new System.Drawing.Size(112, 35);
            this.create_new_connection_button.TabIndex = 3;
            this.create_new_connection_button.Text = "Create";
            this.create_new_connection_button.UseVisualStyleBackColor = true;
            this.create_new_connection_button.Click += new System.EventHandler(this.create_new_connection_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Workers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Create New Connection";
            // 
            // create_new_connection_workers_textbox
            // 
            this.create_new_connection_workers_textbox.Location = new System.Drawing.Point(124, 106);
            this.create_new_connection_workers_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_workers_textbox.Name = "create_new_connection_workers_textbox";
            this.create_new_connection_workers_textbox.Size = new System.Drawing.Size(148, 26);
            this.create_new_connection_workers_textbox.TabIndex = 2;
            this.create_new_connection_workers_textbox.Text = "1";
            // 
            // create_new_connection_port_textbox
            // 
            this.create_new_connection_port_textbox.Location = new System.Drawing.Point(283, 68);
            this.create_new_connection_port_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_port_textbox.Name = "create_new_connection_port_textbox";
            this.create_new_connection_port_textbox.Size = new System.Drawing.Size(148, 26);
            this.create_new_connection_port_textbox.TabIndex = 1;
            this.create_new_connection_port_textbox.Text = "19132";
            // 
            // create_new_connection_host_textbox
            // 
            this.create_new_connection_host_textbox.Location = new System.Drawing.Point(124, 68);
            this.create_new_connection_host_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_host_textbox.Name = "create_new_connection_host_textbox";
            this.create_new_connection_host_textbox.Size = new System.Drawing.Size(148, 26);
            this.create_new_connection_host_textbox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.create_new_connection_binding_textbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.create_new_connection_binding_port_textbox);
            this.groupBox1.Controls.Add(this.create_new_connection_debug_checkbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.create_new_connection_timeout_textbox);
            this.groupBox1.Location = new System.Drawing.Point(10, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 284);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Line Options";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "IP Binding";
            // 
            // create_new_connection_binding_textbox
            // 
            this.create_new_connection_binding_textbox.Location = new System.Drawing.Point(369, 52);
            this.create_new_connection_binding_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_binding_textbox.Name = "create_new_connection_binding_textbox";
            this.create_new_connection_binding_textbox.Size = new System.Drawing.Size(148, 26);
            this.create_new_connection_binding_textbox.TabIndex = 1;
            this.create_new_connection_binding_textbox.Text = "0.0.0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Binding Port";
            // 
            // create_new_connection_binding_port_textbox
            // 
            this.create_new_connection_binding_port_textbox.Location = new System.Drawing.Point(369, 90);
            this.create_new_connection_binding_port_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_binding_port_textbox.Name = "create_new_connection_binding_port_textbox";
            this.create_new_connection_binding_port_textbox.Size = new System.Drawing.Size(148, 26);
            this.create_new_connection_binding_port_textbox.TabIndex = 3;
            this.create_new_connection_binding_port_textbox.Text = "0";
            // 
            // create_new_connection_debug_checkbox
            // 
            this.create_new_connection_debug_checkbox.AutoSize = true;
            this.create_new_connection_debug_checkbox.Location = new System.Drawing.Point(114, 94);
            this.create_new_connection_debug_checkbox.Name = "create_new_connection_debug_checkbox";
            this.create_new_connection_debug_checkbox.Size = new System.Drawing.Size(22, 21);
            this.create_new_connection_debug_checkbox.TabIndex = 2;
            this.create_new_connection_debug_checkbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Debug";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Timeout";
            // 
            // create_new_connection_timeout_textbox
            // 
            this.create_new_connection_timeout_textbox.Location = new System.Drawing.Point(114, 51);
            this.create_new_connection_timeout_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_new_connection_timeout_textbox.Name = "create_new_connection_timeout_textbox";
            this.create_new_connection_timeout_textbox.Size = new System.Drawing.Size(148, 26);
            this.create_new_connection_timeout_textbox.TabIndex = 0;
            this.create_new_connection_timeout_textbox.Text = "60";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.create_new_connection_remove_ports_checkbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.create_new_connection_ipv6_checkbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experimental Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Remove Ports";
            // 
            // create_new_connection_ipv6_checkbox
            // 
            this.create_new_connection_ipv6_checkbox.AutoSize = true;
            this.create_new_connection_ipv6_checkbox.Location = new System.Drawing.Point(143, 32);
            this.create_new_connection_ipv6_checkbox.Name = "create_new_connection_ipv6_checkbox";
            this.create_new_connection_ipv6_checkbox.Size = new System.Drawing.Size(22, 21);
            this.create_new_connection_ipv6_checkbox.TabIndex = 0;
            this.create_new_connection_ipv6_checkbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "IPV6";
            // 
            // create_new_connection_remove_ports_checkbox
            // 
            this.create_new_connection_remove_ports_checkbox.AutoSize = true;
            this.create_new_connection_remove_ports_checkbox.Location = new System.Drawing.Point(143, 75);
            this.create_new_connection_remove_ports_checkbox.Name = "create_new_connection_remove_ports_checkbox";
            this.create_new_connection_remove_ports_checkbox.Size = new System.Drawing.Size(22, 21);
            this.create_new_connection_remove_ports_checkbox.TabIndex = 21;
            this.create_new_connection_remove_ports_checkbox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 705);
            this.Controls.Add(this.create_new_connection_panel);
            this.Controls.Add(this.open_create_new_connection_panel_button);
            this.Controls.Add(this.phantom_connections_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "PhantomGUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Main_ClientSizeChanged);
            this.create_new_connection_panel.ResumeLayout(false);
            this.create_new_connection_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox create_new_connection_ipv6_checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox create_new_connection_binding_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox create_new_connection_binding_port_textbox;
        private System.Windows.Forms.CheckBox create_new_connection_debug_checkbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox create_new_connection_timeout_textbox;
        private System.Windows.Forms.CheckBox create_new_connection_remove_ports_checkbox;
    }
}

