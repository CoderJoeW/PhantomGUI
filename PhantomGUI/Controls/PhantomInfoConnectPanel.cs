using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhantomGUI.Models;
using PhantomGUI.Helpers;

namespace PhantomGUI.Controls
{
    public partial class PhantomInfoConnectPanel : UserControl
    {
        public PhantomInfo phantom_info = new PhantomInfo();

        public delegate void PhantomInfoConnectPanelDeletedEvent(object sender, EventArgs e);

        public event PhantomInfoConnectPanelDeletedEvent PhantomInfoConnectPanelDeleted;

        DBManager db = new DBManager();

        private readonly Main _main;

        public PhantomInfoConnectPanel(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            _main.SetMainTextboxes(phantom_info.server_address);
        }

        private void PhantomInfoConnectPanel_Load(object sender, EventArgs e)
        {
            this.connect_btn.Text = phantom_info.server_name;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            db.DeletePhantomInfoAsync(this.phantom_info.id);
            PhantomInfoConnectPanelDeleted(this, null);
            this.Visible = false;
        }
    }
}
