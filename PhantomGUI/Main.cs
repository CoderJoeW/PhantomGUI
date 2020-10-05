using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhantomGUI.Helpers;
using PhantomGUI.Controls;
using PhantomGUI.Models;

namespace PhantomGUI
{
    public partial class Main : Form
    {
        protected DBManager db = new DBManager();
        private Thread phantom_thread;
        private int process_id;
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

        private void StartPhantom(string parameters)
        {
            Process p = new Process();
            p.StartInfo.FileName = Library.CreatePhantomExecutable();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = parameters;
            p.Start();
            process_id = p.Id;
        }

        private void start_phantom_btn_Click(object sender, EventArgs e)
        {
            start_phantom_btn.Visible = false;
            stop_phantom_btn.Visible = true;
            phantom_thread = new Thread(() => StartPhantom(CreateParametersString()));
            phantom_thread.IsBackground = true;
            phantom_thread.Start();
        }

        private void stop_phantom_btn_Click(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(process_id);
            p.Kill();
            Library.DeletePhantomExecutable();
            stop_phantom_btn.Visible = false;
            start_phantom_btn.Visible = true;
        }

        private string CreateParametersString()
        {
            string parameters = "--server " + hostname_textbox.Text + ":" + port_textbox.Text + " --workers " + worker_textbox.Text;

            return parameters;
        }

        private void advanced_settinsg_button_Click(object sender, EventArgs e)
        {

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
            PhantomInfoConnectPanel phantom_info_connection = new PhantomInfoConnectPanel(this);

            phantom_info_connection.phantom_info = phantom_info;

            phantom_info_connection.Size = new Size(194, 70);

            phantom_info_connection.Parent = phantom_connections_panel;
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
            PhantomInfo pi = new PhantomInfo();
            pi.server_name = create_new_connection_host_textbox.Text;
            pi.server_address = create_new_connection_host_textbox.Text;
            pi.server_port = create_new_connection_port_textbox.Text;
            pi.worker_threads = create_new_connection_workers_textbox.Text;

            await db.SavePhantomInfoAsync(pi);

            await UpdateConnectionsList();

            create_new_connection_panel.Visible = false;
        }

        public void SetMainTextboxes(string hostname)
        {
            hostname_textbox.Text = hostname;
        }

        public async void OnPhantomInfoConnectPanelDeleted(object sender,EventArgs e)
        {
            await UpdateConnectionsList();
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
