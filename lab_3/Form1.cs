namespace lab_3
{
    public partial class Form1 : Form
    {
        public int price_drink;
        public int price_drinks;
        public int price_coffee = 25;
        public int price_tea = 15;
        public int price_cacao = 17;
        public int price_chocolate = 20;
        TimeSpan totalTime;//=new TimeSpan(0,0,1,0);
        TimeSpan coffee_time = new TimeSpan(0, 0, 1, 5);
        TimeSpan tea_time = new TimeSpan(0, 0, 1, 10);
        TimeSpan cacao_time = new TimeSpan(0, 0, 1, 25);
        TimeSpan chocolate_time = new TimeSpan(0, 0, 1, 45);
        DateTime date;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drink_choice.BackColor = Color.Green;

        }

        private void coffee_button_Click(object sender, EventArgs e)
        {
            //  price_drink = price_coffee;
            write_price(price_coffee);
            coffee_button.BackColor = Color.Green;
            totalTime = coffee_time;
            enabled_button();
            pay(0);

        }

        private void tea_button_Click(object sender, EventArgs e)
        {
            //  price_drink = price_tea;
            write_price(price_tea);
            tea_button.BackColor = Color.Green;
            totalTime = tea_time;
            enabled_button();
            pay(0);
        }

        private void cacao_button_Click(object sender, EventArgs e)
        {
            // price_drink = price_cacao;
            write_price(price_cacao);
            cacao_button.BackColor = Color.Green;
            totalTime = cacao_time;
            enabled_button();
            pay(0);

        }

        private void chocolate_button_Click(object sender, EventArgs e)
        {
            //  price_drink = price_chocolate;
            write_price(price_chocolate);
            chocolate_button.BackColor = Color.Green;
            totalTime = chocolate_time;
            enabled_button();
            pay(0);
        }

        public void enabled_button()
        {
            coffee_button.Enabled = !coffee_button.Enabled;
            tea_button.Enabled = !tea_button.Enabled;
            cacao_button.Enabled = !cacao_button.Enabled;
            chocolate_button.Enabled = !chocolate_button.Enabled;
        }
        public void write_price(int money)
        {
            price_drink = money;
            price_drinks = money;
        }
        public void pay(int grn)
        {
            drink_choice.BackColor = Color.White;
            money.BackColor = Color.Green;
            cup.Visible = true;
            tips.Text = $"Внесіть кошти :{price_drink} грн";
            grn_1.Enabled = grn_10.Enabled = grn_100.Enabled = grn_1000.Enabled = grn_2.Enabled =
            grn_20.Enabled = grn_200.Enabled = grn_5.Enabled = grn_50.Enabled = grn_500.Enabled =
            card.Enabled = true;
            price_drink -= grn;
            if (price_drink > 0)
            {
                tips.Text = $"Залишилося ще:{price_drink}грн";
                date = DateTime.Now;
            }
            else
            {
                grn_1.Enabled = grn_10.Enabled = grn_100.Enabled = grn_1000.Enabled = grn_2.Enabled =
            grn_20.Enabled = grn_200.Enabled = grn_5.Enabled = grn_50.Enabled = grn_500.Enabled =
            card.Enabled = false;

                money.BackColor = Color.White;
                proces();
            }
        }

        public void proces()
        {

            totalTime = new TimeSpan(0, 0, 0, 5);

            tips.Text = $"Зачекайте: {totalTime.ToString()}";

            timer1.Start();

            timer1.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            totalTime = totalTime.Subtract(new TimeSpan(0, 0, 0, 1));

            tips.Text = $"Зачекайте: {totalTime.ToString()}";

            if (totalTime.Seconds == 0)
            {
                timer1.Stop();
                drink_to_cup.Visible = false;
                cup.Enabled = true;
                tips.Text = "Візміть свій напій";
                drink.BackColor = Color.Green;
            }
            else
                if(totalTime.Seconds > 0 && totalTime.Seconds < 2)
                {
                drink_to_cup.Visible = true;
                }
        }


        private void cup_Click(object sender, EventArgs e)
        {
            tips.Text = "Візміть чек";
            drink.BackColor = Color.White;
            check.BackColor = Color.Green;
            cup.Visible = false;
            cup.Enabled = false;
            check_button.Enabled = true;
            check_button.Visible = true;
           // chek();
        }


        public void chek()
        {
            string x = $"Вартість = {price_drinks} \nРешта = {-price_drink}  \nДата купівлі :{date}";
            MessageBox.Show(x, "chek") ;
            // MessageBox.Show("Время вышло1");
            check.BackColor = Color.White;
            coffee_button.BackColor = Color.White;
            tea_button.BackColor = Color.White;
            cacao_button.BackColor = Color.White;
            chocolate_button.BackColor = Color.White;
            drink_choice.BackColor = Color.Green;
            check_button.Enabled = false;
            check_button.Visible = false;
            tips.Text = "Виберіть свій напій";
            enabled_button();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            chek();
        }
                // MessageBox.Show("Время вышло");
        private void grn_1_Click(object sender, EventArgs e)
        {
            pay(1);
        }

        private void grn_2_Click(object sender, EventArgs e)
        {
            pay(2);
        }

        private void grn_5_Click(object sender, EventArgs e)
        {
            pay(5);
        }

        private void grn_10_Click(object sender, EventArgs e)
        {
            pay(10);
        }

        private void grn_20_Click(object sender, EventArgs e)
        {
            pay(20);
        }

        private void grn_50_Click(object sender, EventArgs e)
        {
            pay(50);
        }

        private void grn_100_Click(object sender, EventArgs e)
        {
            pay(100);
        }

        private void grn_200_Click(object sender, EventArgs e)
        {
            pay(200);
        }

        private void grn_500_Click(object sender, EventArgs e)
        {
            pay(500);
        }

        private void grn_1000_Click(object sender, EventArgs e)
        {
            pay(1000);
        }

        private void card_Click(object sender, EventArgs e)
        {

        }


    }
}