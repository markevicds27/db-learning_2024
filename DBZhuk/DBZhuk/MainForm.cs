using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBZhuk
{
    public partial class MainForm : Form
    {

        Conn dataBase = new Conn();

        public MainForm()
        {
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonSor_Click(object sender, EventArgs e)
        {
            
            var sor = new SorForm();
                sor.FormClosed += sor_FormClosed;
            Hide();
            sor.ShowDialog();

        }

        private void sor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            
            var sport= new SportForm();
                sport.FormClosed += sport_FormClosed;
            Hide();
            sport.ShowDialog();

        }

        private void sport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonSt_Click(object sender, EventArgs e)
        {
            
            var st= new StForm();
                st.FormClosed += st_FormClosed;
            Hide();
            st.ShowDialog();

        }

        private void st_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonOrg_Click(object sender, EventArgs e)
        {
            
            var org= new OrgForm();
                org.FormClosed += org_FormClosed;
            Hide();
            org.ShowDialog();

        }

        private void org_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            
            var type= new TypeForm();
                type.FormClosed += type_FormClosed;
            Hide();
            type.ShowDialog();

        }

        private void type_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonSpm_Click(object sender, EventArgs e)
        {
            
            var spm= new SpmFrom();
                spm.FormClosed += spm_FormClosed;
            Hide();
            spm.ShowDialog();

        }

        private void spm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonScl_Click(object sender, EventArgs e)
        {
            
            var scl= new SclFrom();
                scl.FormClosed += scl_FormClosed;
            Hide();
            scl.ShowDialog();

        }

        private void scl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonTr_Click(object sender, EventArgs e)
        {
            
            var tr= new TrForm();
                tr.FormClosed += tr_FormClosed;
            Hide();
            tr.ShowDialog();

        }

        private void tr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
