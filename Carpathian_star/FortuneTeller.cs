using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Carpathian_star
{
    public partial class FortuneTeller : Form
    {
        StoreInfo baseForm;
        public FortuneTeller(StoreInfo form)
        {
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);
            baseForm = form;
            baseForm.Hide();
            this.FormClosed += (s, args) => baseForm.form1.Show();
            this.ShowIcon = false;
            this.CenterToScreen();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<string> predictions = new List<string>
        {
            "Незабаром у вашому житті\n з’явиться нова людина.",
            "На вас чекають великі \nзміни на роботі.",
            "Скоро здійсниться ваша давня мрія.",
            "У найближчі дні ви отримаєте \nнесподівану новину.",
            "Цього тижня у вас буде багато \n позитивних емоцій.",
            "На горизонті видно нові\n фінансові можливості.",
            "Вам пощастить у \nнайближчому проекті.",
            "Цього місяця на вас чекає подорож.",
            "Ваші друзі підготують вам сюрприз.",
            "На вас чекає несподівана зустріч \n зі старим знайомим.",
            "Ви знайдете рішення для проблеми,\n яка вас турбує.",
            "Невдовзі ви отримаєте \n важливу пораду.",
            "Вам потрібно звернути увагу\n на своє здоров'я.",
            "Цей рік стане для вас роком\n великих досягнень.",
            "Новий навик змінить ваше життя.",
            "Будьте готові до великого кохання.",
            "Скоро ви знайдете те,\n що давно шукали.",
            "Удача буде супроводжувати вас\n у всіх справах.",
            "Ваші зусилля незабаром будуть\n винагороджені.",
            "Ваша інтуїція підкаже\n правильний шлях."
        };

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (baseForm.form1.Balance >= 200)
            {
                Random rmd = new();
                int index = rmd.Next(predictions.Count);
                FortuneTallerLabel.Text = predictions[index];
                FortuneTallerLabel.Visible = true;
                MessagePictureBox.Visible = true;
                baseForm.form1.Balance -= 200;
                BalanceLabel.Text = baseForm.form1.Balance.ToString();
                string filePath = Path.Combine(Environment.CurrentDirectory, "Dani.json");
                try
                {
                    var jsonData = File.ReadAllText(filePath);
                    var users = JsonSerializer.Deserialize<List<UserData>>(jsonData) ?? new List<UserData>();

                    var user = users.FirstOrDefault(u => u.Login == baseForm.form1.login);
                    if (user != null)
                    {
                        user.Balance = baseForm.form1.Balance;
                    }

                    var updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, updatedJson);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при оновленні файлу: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("У вас недостатньо коштів");
            }
        }
    }
}
