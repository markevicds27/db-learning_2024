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

namespace DBMarkevich
{
    public partial class EatForm : Form
    {

        DataBase dataBase = new DataBase();

        public EatForm()
        {
            InitializeComponent();
        }

        private void EatForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            ClearFieldsS();
            groupBox1.Visible = false;
            LoadComboBoxFood();
            LoadComboBoxAnimal();
        }

        private void GetData()
        {
            var season = comboBox1.Text;

            SqlConnection conn = dataBase.getConnection();

            dataBase.openConnection();

            SqlCommand getEat = new SqlCommand("select eat.ideat, animal.nameanimal, animal.typeanimal, food.namefood, food.typefood, eat.daycount, eat.valueeat from eat, food, animal where eat.idfood = food.idfood and eat.idanimal = animal.idanimal and eat.seasoneat = @season", conn);

            getEat.Parameters.AddWithValue("@season", season);  

            SqlDataAdapter ge = new SqlDataAdapter(getEat);

            DataTable eat = new DataTable();

            ge.Fill(eat);

            dataGridView1.DataSource = eat;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void LoadComboBoxFood()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idfood, namefood from food", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxFood.DataSource = cageBox;
            comboBoxFood.DisplayMember = "namefood";
            comboBoxFood.ValueMember = "idfood";
            comboBoxFoodE.DataSource = cageBox;
            comboBoxFoodE.DisplayMember = "namefood";
            comboBoxFoodE.ValueMember = "idfood";
            conn.Close();
        }

        private void LoadComboBoxAnimal()
        {
            SqlConnection conn = dataBase.getConnection();
            SqlCommand loadBox = new SqlCommand("select idanimal, nameanimal from animal", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadBox);
            sqlDataAdapter.SelectCommand = loadBox;
            DataTable cageBox = new DataTable();
            sqlDataAdapter.Fill(cageBox);
            comboBoxAnimal.DataSource = cageBox;
            comboBoxAnimal.DisplayMember = "nameanimal";
            comboBoxAnimal.ValueMember = "idanimal";
            comboBoxAnimalE.DataSource = cageBox;
            comboBoxAnimalE.DisplayMember = "nameanimal";
            comboBoxAnimalE.ValueMember = "idanimal";
            conn.Close();
        }

        private void ClearFields()
        {
            comboBoxAnimal.Text = "";
            comboBoxFood.Text = "";
            textBoxCount.Text = "";
            textBoxValue.Text = "";
            comboBoxSeason.Text = "";
        }

        private void ClearFieldsS()
        {
            textBoxFoodS.Text = "";
            textBoxAnimalS.Text = "";
            textBoxTypeFoodS.Text = "";
            textBoxTypeAnimalS.Text = "";
        }

        private void ClearFieldsE()
        {
            comboBoxAnimalE.Text = "";
            comboBoxFoodE.Text = "";
            textBoxValueE.Text = "";
            textBoxCountE.Text = "";
            comboBoxSeasonE.Text = "";
        }

        static public string idNum;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            idNum = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var animal = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var food = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var count = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            var value = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            var season = comboBox1.Text;


            comboBoxFoodE.Text = food;
            comboBoxAnimalE.Text = animal;
            textBoxCountE.Text = count;
            textBoxValueE.Text = value;
            comboBoxSeasonE.Text = season;
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int food = int.Parse(comboBoxFood.SelectedValue.ToString());
            int animal = int.Parse(comboBoxAnimal.SelectedValue.ToString());
            int count ;
            var value = textBoxValue.Text;
            var season = comboBoxSeason.Text;

            if (comboBoxFood.Text != "" && comboBoxAnimal.Text != "" && textBoxCount.Text != "" && textBoxValue.Text != "" && comboBoxSeason.Text != "")
            {
                if (int.TryParse(textBoxCount.Text, out count))
                {
                    var addQuery = $"insert into eat (idfood, idanimal, daycount, valueeat, seasoneat) values ('{food}','{animal}', '{count}', '{value}', '{season}')";

                    var addCommand = new SqlCommand(addQuery, dataBase.getConnection());

                    addCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    GetData();
                }
                else
                {
                    MessageBox.Show("Введите целое число в графе количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int animalE = int.Parse(comboBoxAnimalE.SelectedValue.ToString());
            int foodE = int.Parse(comboBoxFoodE.SelectedValue.ToString());
            int countE;
            var valueE = textBoxValueE.Text;
            var seasonE = comboBoxSeasonE.Text;
            

            if (comboBoxAnimalE.Text != "" && comboBoxFoodE.Text != "" && textBoxCountE.Text != "" && textBoxValueE.Text != "" && comboBoxSeasonE.Text != "")
            {
                if (int.TryParse(textBoxCountE.Text, out countE))
                {
                    var editQuery = $"update eat set idanimal = '{animalE}', idfood = '{foodE}', daycount = '{countE}', valueeat = '{valueE}', seasoneat = '{seasonE}' where ideat = '{idNum}'";

                    var editCommand = new SqlCommand(editQuery, dataBase.getConnection());

                    editCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetData();
                    ClearFieldsE();
                    groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Введите целое число в графе количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFieldsE();
            groupBox1.Visible = false;
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
                var delQuery = $"delete from eat where ideat = '{idDel}'";
                var delCommand = new SqlCommand(delQuery, dataBase.getConnection());
                delCommand.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                GetData();
            }
        }

        private void buttonSearchNo_Click(object sender, EventArgs e)
        {
            ClearFieldsS();
            GetData();
        }

        private void textBoxAnimalS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"nameanimal like '%{textBoxAnimalS.Text}%'";
        }

        private void textBoxTypeFoodS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typefood like '%{textBoxTypeFoodS.Text}%'";
        }

        private void textBoxFoodS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"namefood like '%{textBoxFoodS.Text}%'";
        }

        private void textBoxTypeAnimalS_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"typeanimal like '%{textBoxTypeAnimalS.Text}%'";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var post= new PostForm();
                post.FormClosed += post_FormClosed;
            Hide();
                post.ShowDialog();

        }

        private void post_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxFood();
            LoadComboBoxAnimal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var food= new FoodForm();
                food.FormClosed += food_FormClosed;
            Hide();
                food.ShowDialog();

        }

        private void food_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxFood();
            LoadComboBoxAnimal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dost= new DostForm();
                dost.FormClosed += dost_FormClosed;
            Hide();
                dost.ShowDialog();

        }

        private void dost_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            GetData();
            LoadComboBoxFood();
            LoadComboBoxAnimal();
        }
    }
}
