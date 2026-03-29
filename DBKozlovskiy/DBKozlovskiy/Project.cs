using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Net.Mime.MediaTypeNames;

namespace DBKozlovskiy
{
    public partial class Project : Form
    {

        Connection dataBase = new Connection();

        public int dogovor2;

        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            label2.Text = dogovor2.ToString();
            LoadData();
            groupBox1.Visible = false;
        }

        private void buttonTex_Click(object sender, EventArgs e)
        {
            int project1 = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());
            var tex= new AddTex();
                tex.FormClosed += tex_FormClosed;
            tex.project2 = project1;
            Hide();
            tex.ShowDialog();

        }



        private void tex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonEditProject_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
            var name = dataGridViewProject.CurrentRow.Cells[1].Value.ToString();
            var price = dataGridViewProject.CurrentRow.Cells[2].Value.ToString();

            textBox1.Text = name;
            textBox2.Text = price;
        }

        private void buttonDelProject_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from project where idProject = '{id}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            int project1 = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());

            var addWorker = new AddWorker();
            addWorker.FormClosed += addWorker_FromClosed;
            
            addWorker.project2 = project1;
            Hide();
            addWorker.ShowDialog();

        }

        private void addWorker_FromClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonPodryad_Click(object sender, EventArgs e)
        {
            int project1 = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());
           
            var addPodryad= new AddPodryad();
                addPodryad.FormClosed += addPodryad_FormClosed;
            addPodryad.project2 = project1;
            Hide();
            addPodryad.ShowDialog();

        }



        private void addPodryad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonMat_Click(object sender, EventArgs e)
        {
            int project1 = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());


            var mat= new AddMat();
                mat.FormClosed += mat_FormClosed;
            mat.project2 = project1;
            Hide();
            mat.ShowDialog();

        }



        private void mat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
           


            var project= new AddProject();
                project.FormClosed += project_FormClosed;
            project.dogovor3 = dogovor2;
            Hide();
            project.ShowDialog();

        }



        private void project_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void ClearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                dataBase.openConnection();

                int id = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());
                var name = textBox1.Text;
                var price = textBox2.Text;

                var editQuery = $"update project set nameProject = '{name}', priceProject = '{price}' where idProject = '{id}'";

                var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                editCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearTextBox();
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getData = new SqlCommand("select idProject, nameProject, priceProject from project where idDogovor = @idDogovor", conn);

            getData.Parameters.AddWithValue("@idDogovor", dogovor2);

            SqlDataAdapter load = new SqlDataAdapter(getData);

            DataTable data = new DataTable();

            load.Fill(data);

            dataGridViewProject.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idDeleteTex = int.Parse(dataGridViewTex.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from projectTex where idProjectTex = '{idDeleteTex}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idDeletePodryad = int.Parse(dataGridViewPodryad.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from workingPodryad where idWorkingPodryad = '{idDeletePodryad}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idDeleteMat = int.Parse(dataGridViewMat.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from projectMat where idProjectMat = '{idDeleteMat}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idDeleteWorker = int.Parse(dataGridViewWorker.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from workingWorker where idWorkingWorker = '{idDeleteWorker}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int project1 = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());



            var result= new AddResult();
                result.FormClosed += result_FormClosed;
            result.project2 = project1;
            Hide();
            result.ShowDialog();

        }



        private void result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idDeleteResult = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from result where idResult = '{idDeleteResult}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                LoadData();
            }
        }

        private void dataGridViewProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataWorker();
            LoadDataPodryad();
            LoadDataMat();
            LoadDataTex();
            LoadDataResult();
        }

        private void LoadDataWorker()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int projectW = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getDataW = new SqlCommand("select workingWorker.idWorkingWorker, worker.surnameWorker, worker.nameWorker, worker.patronWorker, worker.ageWorker, worker.stazWorker, dolzhnost.nameDolznost, otdel.nameOtdel, workingWorker.nameWorkingWorker from worker, dolzhnost, otdel, status, workingWorker where status.idWorker = worker.idWorker and status.idDolzhnost = dolzhnost.idDolzhnost and status.idOtdel = otdel.idOtdel and workingWorker.idWorker = worker.idWorker and workingWorker.idProject = @idProject", conn);

            getDataW.Parameters.AddWithValue("@idProject", projectW);

            SqlDataAdapter loadW = new SqlDataAdapter(getDataW);

            DataTable dataW = new DataTable();

            loadW.Fill(dataW);

            dataGridViewWorker.DataSource = dataW;
        }

        private void LoadDataPodryad()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int projectP = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getDataP = new SqlCommand("select workingPodryad.idWorkingPodryad, podryad.namePodryad, podryad.facePodryad, workingPodryad.nameWorkingPodryad from podryad, workingPodryad where workingPodryad.idProject = @idProject and workingPodryad.idPodryad = podryad.idPodryad", conn);

            getDataP.Parameters.AddWithValue("@idProject", projectP);

            SqlDataAdapter loadP = new SqlDataAdapter(getDataP);

            DataTable dataP = new DataTable();

            loadP.Fill(dataP);

            dataGridViewPodryad.DataSource = dataP;
        }

        private void LoadDataMat()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int projectM = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getDataM = new SqlCommand("select projectMat.idProjectMat, mat.nameMat, projectMat.countMat from projectMat, mat where idProject = @idProject and projectMat.idMat = mat.idMat", conn);

            getDataM.Parameters.AddWithValue("@idProject", projectM);

            SqlDataAdapter loadM = new SqlDataAdapter(getDataM);

            DataTable dataM = new DataTable();

            loadM.Fill(dataM);

            dataGridViewMat.DataSource = dataM;
        }

        private void LoadDataTex()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int projectT = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getDataT = new SqlCommand("select projectTex.idProjectTex, tex.nameTex, projectTex.dateWork from projectTex, tex where idProject = @idProject and projectTex.idTex = tex.idTex", conn);

            getDataT.Parameters.AddWithValue("@idProject", projectT);

            SqlDataAdapter loadT = new SqlDataAdapter(getDataT);

            DataTable dataT = new DataTable();

            loadT.Fill(dataT);

            dataGridViewTex.DataSource = dataT;
        }

        private void LoadDataResult()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            int projectR = int.Parse(dataGridViewProject.CurrentRow.Cells[0].Value.ToString());

            SqlCommand getDataR = new SqlCommand("select result.idResult, control.nameControl, result.resultControl from result, control where idProject = @idProject and result.idControl = control.idControl", conn);

            getDataR.Parameters.AddWithValue("@idProject", projectR);

            SqlDataAdapter loadR = new SqlDataAdapter(getDataR);

            DataTable dataR = new DataTable();

            loadR.Fill(dataR);

            dataGridView1.DataSource = dataR;
        }


        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewProject.DataSource as DataTable).DefaultView.RowFilter = $"nameProject like '%{textBox3.Text}%'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewProject.DataSource as DataTable).DefaultView.RowFilter = $"priceProject like '%{textBox4.Text}%'";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"surnameWorker like '%{textBox5.Text}%'";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"nameWorker like '%{textBox6.Text}%'";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"patronWorker like '%{textBox7.Text}%'";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"convert(ageWorker, 'System.String') like '%{textBox8.Text}%'";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"convert(stazWorker, 'System.String') like '%{textBox9.Text}%'";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"nameDolznost like '%{textBox10.Text}%'";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewWorker.DataSource as DataTable).DefaultView.RowFilter = $"nameOtdel like '%{textBox11.Text}%'";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewPodryad.DataSource as DataTable).DefaultView.RowFilter = $"namePodryad like '%{textBox12.Text}%'";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewMat.DataSource as DataTable).DefaultView.RowFilter = $"nameMat like '%{textBox13.Text}%'";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewTex.DataSource as DataTable).DefaultView.RowFilter = $"nameTex like '%{textBox14.Text}%'";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameControl like '%{textBox15.Text}%'";
        }
    }
}
