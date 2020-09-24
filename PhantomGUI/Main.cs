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

namespace PhantomGUI
{
    public partial class Main : Form
    {
        Thread phantom_thread;
        int process_id;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
    }
}
