using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBMarkevich
{
    public partial class WorkerForm : Form
    {

        DataBase dataBase = new DataBase();

        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsE();
            ClearFieldsS();                    
            LoadComboBoxStatus();            
            groupBoxEdit.Visible = false;
            
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getWorker = new SqlCommand("select worker.idworker, worker.surnameworker, worker.nameworker, worker.oldnameworker, worker.polworker, worker.ageworker, worker.stazworker, worker.phone, status.namestatus, status.money from worker, status where worker.status = status.idstatus", conn);

            SqlDataAdapter gw = new SqlDataAdapter(getWorker);

            DataTable worker = new DataTable();

            gw.Fill(worker);

            dataGridView1.DataSource = worker;
        }

        private void LoadComboBoxStatus()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idstatus, namestatus from status", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable statusBox = new DataTable();
            sqlDataAdapter.Fill(statusBox);
            comboBoxStatus.DataSource = statusBox;
            comboBoxStatus.DisplayMember = "namestatus";
            comboBoxStatus.ValueMember = "idstatus";
            comboBoxStatusE.DataSource = statusBox;
            comboBoxStatusE.DisplayMember = "namestatus";
            comboBoxStatusE.ValueMember = "idstatus";
            conn.Close();
        }

        private void ClearFields()
        {
            textBoxSurname.Text = "";
            textBoxName.Text = "";
            textBoxOldname.Text = "";
            comboBoxSex.Text = "";
            textBoxAge.Text = "";
            textBoxStaz.Text = "";
            textBoxPhone.Text = "";
            comboBoxStatus.Text = "";
        }

        private void ClearFieldsE()
        {
            textBoxSurnameE.Text = "";
            textBoxNameE.Text = "";
            textBoxOldnameE.Text = "";
            comboBoxSexE.Text = "";
            textBoxAgeE.Text = "";
            textBoxStazE.Text = "";
            textBoxPhoneE.Text = "";
            comboBoxStatusE.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxSurnameS.Text = "";
            textBoxNameS.Text = "";
            textBoxOldnameS.Text = "";
            textBoxSexS.Text = "";
            textBoxAgeS.Text = "";
            textBoxStazS.Text = "";
            textBoxPhoneS.Text = "";
            textBoxStatusS.Text = "";
        }


        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();           

            var surname = textBoxSurname.Text;
            var name = textBoxName.Text;
            var oldname = textBoxOldname.Text;
            var sex = comboBoxSex.Text;
            int age;
            int staz;
            var phone = textBoxPhone.Text;
            int status = int.Parse(comboBoxStatus.SelectedValue.ToString());

            if (textBoxSurname.Text != "" && textBoxName.Text != "" && textBoxOldname.Text != "" && comboBoxSex.Text != "" && textBoxAge.Text != "" && textBoxStaz.Text != "" && textBoxPhone.Text != "" && comboBoxStatus.Text != "")
            {
                if (int.TryParse(textBoxAge.Text, out age))
                {
                    if (int.TryParse(textBoxStaz.Text, out staz))
                    {
                        var addQuery = $"insert into worker (surnameworker, nameworker, oldnameworker, polworker, ageworker, stazworker, phone, status) values ('{surname}','{name}','{oldname}','{sex}','{age}','{staz}','{phone}','{status}')";

                        var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                        addCommand.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число в графе стаж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите целое число в графе возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void buttonAddNo_Click(object sender, EventArgs e)
        {
            ClearFields();            
            GetData();
        }

        static public string idNum;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = true;
            
            idNum = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var oldname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var sex = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            var age = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            var staz = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            var phone = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            var status = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            textBoxSurnameE.Text = surname;
            textBoxNameE.Text = name;
            textBoxOldnameE.Text = oldname;
            comboBoxSexE.Text = sex;
            textBoxAgeE.Text = age;
            textBoxStazE.Text = staz;
            textBoxPhoneE.Text = phone;
            comboBoxStatusE.Text = status;
        }

        private void buttonEditNo_Click(object sender, EventArgs e)
        {
            ClearFieldsE();
            groupBoxEdit.Visible = false;
            GetData();           
        }

        private void buttonEditOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();           

            var surnameE = textBoxSurnameE.Text;
            var nameE = textBoxNameE.Text;
            var oldnameE = textBoxOldnameE.Text;
            var sexE = comboBoxSexE.Text;
            int ageE;
            int stazE;
            var phoneE = textBoxPhoneE.Text;
            int statusE = int.Parse(comboBoxStatus.SelectedValue.ToString());

            if (textBoxSurnameE.Text != "" && textBoxNameE.Text != "" && textBoxOldnameE.Text != "" && comboBoxSexE.Text != "" && textBoxAgeE.Text != "" && textBoxStazE.Text != "" && textBoxPhoneE.Text != "" && comboBoxStatusE.Text != "")
            {
                if (int.TryParse(textBoxStazE.Text, out stazE))
                {
                    if (int.TryParse(textBoxAgeE.Text, out ageE))
                    {
                        var editQuery = $"update worker set surnameworker = '{surnameE}', nameworker = '{nameE}', oldnameworker = '{oldnameE}', polworker = '{sexE}', ageworker = '{ageE}', stazworker = '{stazE}', phone = '{phoneE}', status = '{statusE}' where idworker = '{idNum}'";

                        var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                        editCommand.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetData();
                        ClearFieldsE();
                        groupBoxEdit.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число в графе возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите целое число в графе стаж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery = $"delete from worker where idworker = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }              

        private void textBoxSurnameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"surnameworker like '%{textBoxSurnameS.Text}%'";
        }

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
        }
        
        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameworker like '%{textBoxNameS.Text}%'";
        }

        private void textBoxOldnameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"oldnameworker like '%{textBoxOldnameS.Text}%'";
        }        

        private void textBoxPhoneS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"phoneworker like '%{textBoxPhoneS.Text}%'";
        }          

        private void textBoxAgeS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(ageworker, 'System.String') like '%{textBoxAgeS.Text}%'";
        }

        private void textBoxStazS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(stazworker, 'System.String') like '%{textBoxStazS.Text}%'";
        }

        private void textBoxStatusS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namestatus like '%{textBoxStatusS.Text}%'";
        }

        private void textBoxSexS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"polworker like '%{textBoxSexS.Text}%'";
        }        

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            
            var status = new StatusForm();
            status.FormClosed += status_FormClosed;
            Hide();
            status.ShowDialog();

        }

        private void status_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxStatus();
        }

        private void buttonZakrep_Click(object sender, EventArgs e)
        {

            var zakrep = new ZakrepForm();
            zakrep.FormClosed += zakrep_FormClosed;
            Hide();
            zakrep.ShowDialog();

        }

        private void zakrep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxStatus();
        }



        private void buttonMed_Click(object sender, EventArgs e)
        {

            var med = new MedForm();
            med.FormClosed += med_FormClosed;
            Hide();
            med.ShowDialog();

        }

        private void med_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxStatus();
        }

        private void buttonCage_Click(object sender, EventArgs e)
        {

            var cage = new CageForm();
            cage.FormClosed += cage_FormClosed;
            Hide();
            cage.ShowDialog();

        }

        private void cage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxStatus();
        }


        private void buttonFood_Click(object sender, EventArgs e)
        {
            var food = new EatForm();
            food.FormClosed += food_FormClosed;
            Hide();
            food.ShowDialog();

        }

        private void food_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxStatus();
        }
    }
}
