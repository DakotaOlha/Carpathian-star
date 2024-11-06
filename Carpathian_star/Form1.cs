using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Carpathian_star
{
    public partial class Form1 : Form
    {
        public long Balance = 0;
        public string login, password;
        int count = 0;
        EnterWindow childForm;

        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);
            childForm = new EnterWindow(this);
            childForm.FormClosed += (s, args) => this.Show();
            this.Text = "";
            this.ShowIcon = false;
            var screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height / 2 - this.Height / 2;
            this.Left = screen.Bounds.Width / 2 - this.Width / 2;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
                ++count;
                childForm.ShowDialog();
                this.Hide();
            }
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Store1.BackColor = Color.GreenYellow;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Store1.BackColor = Color.SeaGreen;
        }
        private void Store8_MouseEnter(object sender, EventArgs e)
        {
            Store8.BackColor = Color.GreenYellow;
        }
        private void Store8_MouseLeave(object sender, EventArgs e)
        {
            Store8.BackColor = Color.SeaGreen;
        }
        private void Store2_MouseEnter(object sender, EventArgs e)
        {

            Store2.BackColor = Color.GreenYellow;
        }
        private void Store2_MouseLeave(object sender, EventArgs e)
        {
            Store2.BackColor = Color.SeaGreen;
        }
        private void Store3_MouseEnter(object sender, EventArgs e)
        {
            Store3.BackColor = Color.GreenYellow;
        }
        private void Store3_MouseLeave(object sender, EventArgs e)
        {
            Store3.BackColor = Color.SeaGreen;
        }
        private void Store7_MouseEnter(object sender, EventArgs e)
        {
            Store7.BackColor = Color.Red;
        }
        private void Store7_MouseLeave(object sender, EventArgs e)
        {
            Store7.BackColor = Color.SeaGreen;
        }
        private void Store6_MouseEnter(object sender, EventArgs e)
        {
            Store6.BackColor = Color.GreenYellow;
        }
        private void Store6_MouseLeave(object sender, EventArgs e)
        {
            Store6.BackColor = Color.SeaGreen;
        }
        private void Store4_MouseEnter(object sender, EventArgs e)
        {
            Store4.BackColor = Color.GreenYellow;
        }
        private void Store4_MouseLeave(object sender, EventArgs e)
        {
            Store4.BackColor = Color.SeaGreen;
        }
        private void Store5_MouseEnter(object sender, EventArgs e)
        {
            Store5.BackColor = Color.GreenYellow;
        }
        private void Store5_MouseLeave(object sender, EventArgs e)
        {

            Store5.BackColor = Color.SeaGreen;
        }

        private void Store1_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 7);
            storeInfo.SetLabelText("Галина, досвідчена ворожка з особливим даром інтуїції. Вона допомагає людям знайти " +
                "відповіді на важливі питання та віднайти свій шлях у житті.",
              "Ворожіння на картах Таро та рунах, поради щодо життєвих рішень і любові.",
               "Вівторок — неділя, з 12:00 до 18:00. Понеділок — день для відновлення енергії після передбачення всього, " +
               "що може трапитись, а з 12:00 до 18:00 Галина на пік своєї ясності (і кави).",
               "\"Тайна Галі\" — місце, де кожен знаходить відповіді на свої питання і нову енергію для змін. " +
               "Клієнти часто повертаються за підтримкою та порадами.");


            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        public void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Store4_Click(object sender, EventArgs e)
        {            
            StoreInfo storeInfo = new StoreInfo(this, 1);
            storeInfo.SetLabelText("Михайло Паланок, відомий своєю привітністю і майстерністю у виготовленні наливок. " +
                           "Він знає кожного постійного клієнта на ім'я і завжди готовий підняти настрій веселою історією.", 
                           "Натуральні наливки з місцевих фруктів та ягід. Від класичних сливових і вишневих, " +
                            "до екзотичних закарпатських міксів.",
                            "Магазин працює з понеділка по суботу, з 10:00 до 18:00. Неділя — святковий день, " +
                            "адже навіть найкращим наливкам потрібен відпочинок.",
                            "За роки роботи \"Смак Закарпаття\" здобув репутацію місця, де можна не тільки скуштувати найкращі наливки, " +
                            "але й отримати заряд позитивних емоцій. Клієнти кажуть," +
                            " що після відвідування магазину життя стає солодшим, а настрій піднімається до небес.");

            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store8_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 2);
            storeInfo.SetLabelText("Пане Іван, майстер з 30-річним досвідом та золотими руками.",
                          "Глиняні горщики всіх форм і розмірів, від мініатюрних сувенірів до великих казанів для борщу.",
                           "Понеділок – субота з 9:00 до 18:00. Неділя – день відпочинку і натхнення.",
                           "Відомий як \"Закарпатський гончарний рай\", магазин Івана має бездоганну репутацію. " +
                           "Клієнти приходять сюди, щоб придбати унікальні вироби, що випромінюють тепло та душу Закарпаття.");

            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store5_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 3);
            storeInfo.SetLabelText("Добродушний пан Василь, який знає все про трави і завжди радий допомогти.",
              "Від класичних лікарських рослин до екзотичних трав для чаювання, спецій та ароматерапії.",
               "Понеділок - Субота, з 9:00 до 18:00. Неділля - вихідний, бо трави теж відпочивають.",
               " Відомий на всю область як \"Трав'яний рай\", де можна знайти траву на будь-який смак і потребу.");

            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store2_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 4);
            storeInfo.SetLabelText("Віктор \"Коврик\" Петренко",
            " Від килимів ручної роботи до практичних доріжок – у нас знайдеться коврик для кожного куточка вашого дому.",
             "Працюємо без вихідних! Від понеділка до неділі з 9:00 до 19:00.",
             " Кажуть, що у нас такі коврики, що не захочеш знімати взуття. Відгуки тільки найкращі - від місцевих жителів " +
             "до туристів з усієї України.\r\n");

            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store3_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 5);
            storeInfo.SetLabelText("Пан Іван, справжній гуцул із веселим характером та безмежною любов'ю до рідного краю.",
            " Широкий асортимент: магнітики з видами Карпат, брелки у формі мініатюрних дерев'яних трембіт, гердани ручної " +
            "роботи з національними орнаментами.",
             "Щодня з 9:00 до 19:00, без вихідних, адже краса Карпат не знає відпочинку!",
            " Магазин відомий своєю гостинністю та якістю товарів. Кожен відвідувач іде з посмішкою та частинкою Закарпаття у " +
            "серці. Тут кажуть: \"Купив сувенір — знайшов друга!\"");

            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store6_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 6);
            storeInfo.SetLabelText("пані Оксана",
            " Вишукані вишиванки на будь-який смак – від класичних орнаментів до сучасних мотивів, з якими ви станете зіркою будь-якого свята!",
             " Понеділок - субота: 10:00 - 18:00, неділя - вихідний (пані Оксана ходить до церкви).",
             " а відгуками клієнтів, вишиванки такі гарні, що навіть сусідські бабусі запитують, де ви їх придбали!");

            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Exit_Click(sender, e);
            }
        }
    }
}
