using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string login = "admin";
        string password = "admin";
        public Form1()
        {

            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*login = textBox1.Text;*/
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*password = textBox2.Text;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using MySql.Data.MySqlClient; // Не забудьте добавить этот using*/

            //string connectionString = "127.0.0.1;midvidiv123;root;gamemode17";

            /* string server = "localhost";
             string database = "Local instance MySQL80";
             string userId = "root";
             string password = "gamemode17";

             string connectionString = $"Server={server};Database={database};User ID={userId};Password={password};";

             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 try
                 {
                     connection.Open();
                     string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                     MySqlCommand command = new MySqlCommand(query, connection);
                     command.Parameters.AddWithValue("@username", textBox1.Text);
                     command.Parameters.AddWithValue("@password", textBox2.Text); // Лучше использовать хеширование!

                     int count = Convert.ToInt32(command.ExecuteScalar());
                     if (count > 0)
                     {
                         MessageBox.Show("Успешная авторизация!");
                     }
                     else
                     {
                         MessageBox.Show("Ошибка авторизации. Проверьте вводимые данные.");
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Ошибка подключения: " + ex.Message);
                 }
             }*/





            if (textBox1.Text == login && textBox2.Text == password)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

