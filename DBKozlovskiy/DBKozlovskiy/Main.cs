using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBKozlovskiy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            var tex= new Tex();
            tex.FormClosed += tex_FormClosed;
            Hide();
            tex.ShowDialog();
        }

        private void tex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dogovor = new Dogovora();
            dogovor.FormClosed += dogovor_FormClosed;
            Hide();
            dogovor.ShowDialog();
        }

        private void dogovor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var worker = new Worker();
            worker.FormClosed += worker_FormClosed;
            Hide();
            worker.ShowDialog();
        }

        private void worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var podryad = new Podryad();
            podryad.FormClosed += podryad_FormClosed;
            Hide();
            podryad.ShowDialog();
        }

        private void podryad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newDogovor = new NewDogovor();
            newDogovor.FormClosed += newDogovor_FormClosed;
            Hide();
            newDogovor.ShowDialog();
        }

        private void newDogovor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var mat= new Mat();
            mat.FormClosed += mat_FormClosed;
            Hide();
            mat.ShowDialog();
        }

        private void mat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var dol= new Dolzhnost();
            dol.FormClosed += dol_FormClosed;
            Hide();
            dol.ShowDialog();
        }

        private void dol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var otdel= new Otdel();
            otdel.FormClosed += otdel_FormClosed;
            Hide();
            otdel.ShowDialog();
        }

        private void otdel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            var control = new Control();
            control.FormClosed += control_FormClosed;
            Hide();
            control.ShowDialog();
        }

        private void control_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
