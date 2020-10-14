using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhantomGUI.Helpers;
using PhantomGUI.Controls;
using PhantomLib.Models;

namespace PhantomGUI
{
    public partial class Main : Form
    {
        protected DBManager db = new DBManager();
        private List<PhantomInfoConnectPanel> phantom_info_control_panels_list = new List<PhantomInfoConnectPanel>();

        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await UpdateConnectionsList();
            CenterCreateNewConnectionPanel();
        }

        private async Task UpdateConnectionsList()
        {
            ClearControlsList();

            List<PhantomInfo> t_phantom_info_list = await db.GetPhantomInfosAsync();

            foreach (PhantomInfo pi in t_phantom_info_list)
            {
                PhantomInfoConnectPanel picp = CreateNewPhantonInfoConnectionButton(pi);
                picp.PhantomInfoConnectPanelDeleted += OnPhantomInfoConnectPanelDeleted;
            }
        }

        private void ClearControlsList()
        {
            phantom_connections_panel.Controls.Clear();
            ClearConnectionsList();
        }

        private void ClearConnectionsList()
        {
            phantom_info_control_panels_list.Clear();
        }

        private PhantomInfoConnectPanel CreateNewPhantonInfoConnectionButton(PhantomInfo phantom_info)
        {
            PhantomInfoConnectPanel phantom_info_connection = new PhantomInfoConnectPanel
            {
                phantom_info = phantom_info, 
                Size = new Size(194, 70), 
                Parent = phantom_connections_panel
            };

            phantom_info_connection.Location = new Point(3, (phantom_info_control_panels_list.Count * phantom_info_connection.Height) + (3 * phantom_info_control_panels_list.Count));

            phantom_info_control_panels_list.Add(phantom_info_connection);
            phantom_connections_panel.Controls.Add(phantom_info_connection);

            return phantom_info_connection;
        }

        private void open_create_connection_panel_button_Click(object sender, EventArgs e)
        {
            create_new_connection_panel.Visible = true;
            create_new_connection_host_textbox.Focus();
        }

        private void close_create_connection_panel_button_Click(object sender, EventArgs e)
        {
            create_new_connection_panel.Visible = false;
        }

        private async void create_new_connection_button_Click(object sender, EventArgs e)
        {
            if (!IsValidTimeoutValue())
            {
                MessageBox.Show("Please provide a valid number for the timeout value", "Invalid Timeout Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PhantomInfo pi = new PhantomInfo
            {
                ServerName = create_new_connection_host_textbox.Text,
                ServerAddress = create_new_connection_host_textbox.Text,
                ServerPort = create_new_connection_port_textbox.Text,
                WorkerThreads = create_new_connection_workers_textbox.Text,
                Timeout = create_new_connection_timeout_textbox.Text,
                Ipv6 = create_new_connection_ipv6_checkbox.Checked,
                RemovePorts = create_new_connection_remove_ports_checkbox.Checked,
                Debug = create_new_connection_debug_checkbox.Checked,
                Bind = create_new_connection_binding_textbox.Text,
                BindPort = create_new_connection_binding_port_textbox.Text
            };

            await db.SavePhantomInfoAsync(pi);

            await UpdateConnectionsList();

            create_new_connection_panel.Visible = false;
        }

        public async void OnPhantomInfoConnectPanelDeleted(object sender,EventArgs e)
        {
            await UpdateConnectionsList();
        }

        private bool IsValidTimeoutValue()
        {
            if (string.IsNullOrEmpty(create_new_connection_timeout_textbox.Text))
                return true;

            return int.TryParse(create_new_connection_timeout_textbox.Text, out _);
        }

        #region Drawing

        private void Main_ClientSizeChanged(object sender, EventArgs e)
        {
            CenterCreateNewConnectionPanel();
        }

        protected void CenterCreateNewConnectionPanel()
        {
            create_new_connection_panel.Location = new Point(this.ClientSize.Width / 2 - create_new_connection_panel.Size.Width /2, this.ClientSize.Height / 2 - create_new_connection_panel.Size.Height /2);
        }
        #endregion
    }
}
