using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhantomGUI.Helpers;
using System.Diagnostics;
using PhantomLib.Models;

namespace PhantomGUI.Controls
{
    public partial class PhantomInfoConnectPanel : UserControl
    {
        public PhantomInfo phantom_info = new PhantomInfo();

        public delegate void PhantomInfoConnectPanelDeletedEvent(object sender, EventArgs e);

        public event PhantomInfoConnectPanelDeletedEvent PhantomInfoConnectPanelDeleted;

        private DBManager db = new DBManager();

        private Thread phantom_thread;

        protected int process_id;

        public PhantomInfoConnectPanel()
        {
            InitializeComponent();
        }

        private void StartPhantomInstance(string parameters)
        {
            Process p = new Process();
            p.StartInfo.FileName = Library.CreatePhantomExecutable(phantom_info.ServerName);
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = parameters;
            p.Start();
            process_id = p.Id;
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            phantom_thread = new Thread(() => StartPhantomInstance(Library.CreateParametersString(phantom_info)));
            phantom_thread.IsBackground = true;
            phantom_thread.Start();

            stop_instance_button.Visible = true;
        }

        private void PhantomInfoConnectPanel_Load(object sender, EventArgs e)
        {
            this.connect_btn.Text = phantom_info.ServerName;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            db.DeletePhantomInfoAsync(this.phantom_info.Id);
            PhantomInfoConnectPanelDeleted(this, null);
            this.Visible = false;
        }

        private void stop_instance_button_Click(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(process_id);
            p.Kill();
            Library.DeletePhantomExecutable(phantom_info.ServerName);
            stop_instance_button.Visible = false;
        }
    }
}
