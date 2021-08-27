using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AdminPasswordSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Exit_Application_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AdminPasswordSetOption()
        {
            System.Diagnostics.Process Admin_Password_Set_Option = System.Diagnostics.Process.Start(@"C:\Windows\ParthSofts\Admin Password Set.exe");
        }
        public void AdminPasswordRemoveOption()
        {
            System.Diagnostics.Process Admin_Password_Remove_Option = System.Diagnostics.Process.Start(@"C:\Windows\ParthSofts\Admin Password Remove.exe");
        }
        private void Admin_Password_Set_Click(object sender, EventArgs e)
        {
            AdminPasswordSetOption();
        }
        private void Admin_Password_Remove_Click(object sender, EventArgs e)
        {
            AdminPasswordRemoveOption();
        }
    }
}