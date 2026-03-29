using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMarkevich
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
           
            var animal = new AnimalForm();
            animal.FormClosed += animal_FormClosed;
            Hide();
            animal.ShowDialog();

        }



        private void animal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {            
            var worker = new WorkerForm();
            worker.FormClosed += worker_FormClosed;
            Hide();
            worker.ShowDialog();

        }



        private void worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
