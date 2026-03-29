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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;

namespace DBMarkevich
{
    public partial class AnimalForm : Form
    {

        DataBase dataBase = new DataBase();

        public AnimalForm()
        {
            InitializeComponent();
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            GetData();
            ClearFields();
            ClearFieldsE();
            ClearFieldsS();            
            LoadComboBoxCage();            
            groupBoxEdit.Visible = false;            
        }

        private void GetData()
        {
            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getAnimal = new SqlCommand("select animal.idanimal, animal.nameanimal, animal.typeanimal, animal.polanimal, animal.ageanimal, animal.rost, animal.ves, animal.soz, animal.winter, cage.idcage, cage.namecage from animal, cage where animal.cage = cage.idcage", conn);

            SqlDataAdapter ga = new SqlDataAdapter(getAnimal);

            DataTable animal = new DataTable();

            ga.Fill(animal);

            dataGridView1.DataSource = animal;
        }        

        private void LoadComboBoxCage()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idcage, namecage from cage", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxCage.DataSource = cageBox;
            comboBoxCage.DisplayMember = "namecage";
            comboBoxCage.ValueMember = "idcage";
            comboBoxCageE.DataSource = cageBox;
            comboBoxCageE.DisplayMember = "namecage";
            comboBoxCageE.ValueMember = "idcage";
            conn.Close();
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            comboBoxType.Text = "";
            comboBoxSex.Text = "";
            textBoxAge.Text = "";
            textBoxRost.Text = "";
            textBoxVes.Text = "";
            textBoxSoz.Text = "";
            comboBoxWinter.Text = "";            
            comboBoxCage.Text = "";
        }

        private void ClearFieldsE()
        {
            textBoxNameE.Text = "";
            comboBoxTypeE.Text = "";
            comboBoxSexE.Text = "";
            textBoxAgeE.Text = "";
            textBoxRostE.Text = "";
            textBoxVesE.Text = "";
            textBoxSozE.Text = "";
            comboBoxWinterE.Text = "";            
            comboBoxCageE.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxNameS.Text = "";
            textBoxVidS.Text = "";
            textBoxSexS.Text = "";
            textBoxAgeS.Text = "";
            textBoxRostS.Text = "";
            textBoxVesS.Text = "";
            comboBoxSozS.Text = "";
            textBoxWinterS.Text = "";           
            textBoxCageS.Text = "";
        }       

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();            

            var name = textBoxName.Text;
            var vid = comboBoxType.Text;
            var sex = comboBoxSex.Text;
            int age;
            int rost;
            int ves;
            int soz;
            var winter = comboBoxWinter.Text;            
            int cage = int.Parse(comboBoxCage.SelectedValue.ToString());

            if (textBoxName.Text != "" && comboBoxType.Text != "" && comboBoxSex.Text != "" && textBoxAge.Text != "" && textBoxVes.Text != "" && textBoxRost.Text != "" && textBoxSoz.Text  != "" && comboBoxCage.Text != "" && comboBoxWinter.Text != "")
            {
                if (int.TryParse(textBoxAge.Text, out age))
                {
                    if (int.TryParse(textBoxRost.Text, out rost))
                    {
                        if (int.TryParse(textBoxVes.Text, out ves))
                        {
                            if (int.TryParse(textBoxSoz.Text, out soz))
                            {

                                var addQuery = $"insert into animal (nameanimal, typeanimal, polanimal, ageanimal, rost, ves, soz, winter, cage) values ('{name}','{vid}','{sex}','{age}','{rost}','{ves}','{soz}','{winter}', '{cage}')";

                                var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                                addCommand.ExecuteNonQuery();

                                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                GetData();
                            }
                            else
                            {
                                MessageBox.Show("Введите целое число в графе возраст созревания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите целое число в графе вес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число в графе рост", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var vid = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var sex = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var age = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            var rost = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            var ves = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            var soz = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            var winter = dataGridView1.CurrentRow.Cells[8].Value.ToString();            
            var cage = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            textBoxNameE.Text = name;
            comboBoxTypeE.Text = vid;
            comboBoxSexE.Text = sex;
            textBoxAgeE.Text = age; 
            textBoxRostE.Text = rost;
            textBoxVesE.Text = ves;
            textBoxSozE.Text = soz;
            comboBoxWinterE.Text = winter;          
            comboBoxCageE.Text = cage;

        }

        private void buttonEditOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();          

            var nameE = textBoxNameE.Text;
            var vidE = comboBoxTypeE.Text;
            var sexE = comboBoxSexE.Text;
            int ageE = int.Parse(textBoxAgeE.Text);
            int rostE = int.Parse(textBoxRostE.Text);
            int vesE = int.Parse(textBoxVesE.Text);
            int sozE = int.Parse(textBoxSozE.Text);
            var winterE = comboBoxWinterE.Text;            
            int cageE = int.Parse(comboBoxCageE.SelectedValue.ToString());

            if (textBoxNameE.Text != "" && comboBoxTypeE.Text != "" && comboBoxSexE.Text != "" && textBoxAgeE.Text != "" && textBoxVesE.Text != "" && textBoxRostE.Text != "" && textBoxSozE.Text != "" && comboBoxCageE.Text != "" && comboBoxWinterE.Text != "")
            {
                if (int.TryParse(textBoxAgeE.Text, out ageE))
                {
                    if (int.TryParse(textBoxRostE.Text, out rostE))
                    {
                        if (int.TryParse(textBoxVesE.Text, out vesE))
                        {
                            if (int.TryParse(textBoxSozE.Text, out sozE))
                            {
                                var editQuery = $"update animal set nameanimal = '{nameE}', typeanimal = '{vidE}', polanimal = '{sexE}', ageanimal = '{ageE}', rost = '{rostE}', ves = '{vesE}', soz = '{sozE}', winter = '{winterE}', cage = '{cageE}' where idanimal = '{idNum}'";

                                var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                                editCommand.ExecuteNonQuery();

                                MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GetData();
                                ClearFieldsE();
                                groupBoxEdit.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Введите целое число в графе возраст созревания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите целое число в графе вес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число в графе рост", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonEditNo_Click(object sender, EventArgs e)
        {
            ClearFieldsE();
            groupBoxEdit.Visible = false;
            GetData();
        }

        static public string idDel;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            idDel = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {

                dataBase.openConnection();
                var delQuery1 = $"delete from zakrep where idanimal = '{idDel}'";
                var delCommand1 = new SqlCommand(delQuery1, dataBase.getConnection());
                delCommand1.ExecuteNonQuery();
                var delQuery = $"delete from animal where idanimal = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }        

        private void textBoxNameS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameanimal like '%{textBoxNameS.Text}%'";
        }

        private void textBoxVidS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typeanimal like '%{textBoxVidS.Text}%'";
        }

        private void textBoxSexS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"polanimal like '%{textBoxSexS.Text}%'";
        }

        private void textBoxAgeS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(ageanimal, 'System.String') like '%{textBoxAgeS.Text}%'";
        }

        private void textBoxRostS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(rost, 'System.String') like '%{textBoxRostS.Text}%'";
        }

        private void textBoxVesS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(ves, 'System.String') like '%{textBoxVesS.Text}%'";
        }

        private void comboBoxSozS_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSozS.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"soz < ageanimal";
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"soz > ageanimal";
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void textBoxWinterS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"winter like '%{textBoxWinterS.Text}%'";
        }        

        private void textBoxCageS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"convert(idcage, 'System.String') like '%{textBoxCageS.Text}%'";
        }

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
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
            LoadComboBoxCage();
        }


        private void buttonFood_Click(object sender, EventArgs e)
        {
            var food= new EatForm();
                food.FormClosed += food_FormClosed;
            Hide();
            food.ShowDialog();

        }

        private void food_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
        }

    }
}
