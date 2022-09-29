namespace lab_3
{
    public partial class Form1 : Form
    {
        public int price_Drink;
        public int price_Drinks;
        public int price_coffee = 25;
        public int price_tea = 15;
        public int price_cacao = 17;
        public int price_chocolate = 20;

        TimeSpan totalTime;
        TimeSpan coffee_time = new TimeSpan(0, 0, 1, 5);
        TimeSpan tea_time = new TimeSpan(0, 0, 1, 10);
        TimeSpan cacao_time = new TimeSpan(0, 0, 1, 25);
        TimeSpan chocolate_time = new TimeSpan(0, 0, 1, 45);
        DateTime date;



        public int id_drink;
        public string name_drink;
        public int portion_drink;
        public int price_drink;

        public int id_mc;
        public int check_paper_mc;
        public int cups_mc;
        public int sugar_mc;

        public int id_machine;
        public int id_mc_ma;
        public int id_drink_1_ma;
        public int id_drink_2_ma;
        public int id_drink_3_ma;
        public int id_drink_4_ma;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            drink_choice.BackColor = Color.Green;
            //////////////////////////////////////
            using var db = new MachineContext();

             update_list_drink();
             update_list_mc();
             update_list_ma();
        }

        public void add_drink(int id,string name,int portion,int price)
        {
            using var db = new MachineContext();
            var drink = new Drink
            {
                DrinkId = id,
                Name_Drink = name,
                Portion_Drink = portion,
                Price_Drink = price,
            };
            db.Add(drink);
            db.SaveChanges();
            update_list_drink();

        }

        public void add_mc(int id,int check_paper, int cups,int sugar)
        {
            using var db = new MachineContext();
            var mc = new Machine_component
            {
               Machine_componentId=id,
                Sugar=sugar,
                CheckPaper=check_paper,
                Cups=cups,
            };
            db.Add(mc);
            db.SaveChanges();
            update_list_ma();
        }

        public void add_machine(int id,int id_mc,int drink_1, int drink_2, int drink_3, int drink_4)
        {
               using var db = new MachineContext();
               var mc = new Machine
               {
                   MachineId=id,
                   Machine_components=id_mc,
                   Drink_1=drink_1,
                   Drink_2=drink_2,
                   Drink_3=drink_3,
                   Drink_4=drink_4,
               };
               db.Add(mc);
               db.SaveChanges();
            update_list_ma();
        }

        public void update_list_drink()
        {
            drinks_list.Items.Clear();
            using var db = new MachineContext();
            foreach (var item in db.Drinks)
            {
                drinks_list.Items.Add(item.DrinkId +" "+ item.Name_Drink 
                    + " " + item.Portion_Drink + " " + item.Price_Drink);
            }
        }

        public void update_list_mc()
        {
            mc_list.Items.Clear();
            using var db = new MachineContext();
            foreach (var item in db.Components)
            {
                mc_list.Items.Add(item.Machine_componentId + " " +item.CheckPaper 
                    + " " +item.Cups + " " + item.Sugar);
            }
        }

        public void update_list_ma()
        {    
            ma_list.Items.Clear();
            using var db = new MachineContext();
            
            foreach (var item in db.Machines)
            {
                ma_list.Items.Add(item.MachineId+" "+item.Machine_components + " " +item.Drink_1
                    + " " +item.Drink_2 + " " +item.Drink_3 + " " +item.Drink_4);
            }

           
        }

        private void coffee_button_Click(object sender, EventArgs e)
        {
            //  price_drink = price_coffee;
            write_price(price_coffee);
            drink_1_button.BackColor = Color.Green;
            totalTime = coffee_time;
            enabled_button();
            pay(0);

        }

        private void tea_button_Click(object sender, EventArgs e)
        {
            //  price_drink = price_tea;
            write_price(price_tea);
            drink_3_button.BackColor = Color.Green;
            totalTime = tea_time;
            enabled_button();
            pay(0);
        }

        private void cacao_button_Click(object sender, EventArgs e)
        {
            // price_drink = price_cacao;
            write_price(price_cacao);
            drink_2_button.BackColor = Color.Green;
            totalTime = cacao_time;
            enabled_button();
            pay(0);

        }

        private void chocolate_button_Click(object sender, EventArgs e)
        {
            //  price_drink = price_chocolate;
            write_price(price_chocolate);
            drink_4_button.BackColor = Color.Green;
            totalTime = chocolate_time;
            enabled_button();
            pay(0);
        }

        public void enabled_button()
        {
            drink_1_button.Enabled = !drink_1_button.Enabled;
            drink_3_button.Enabled = !drink_3_button.Enabled;
            drink_2_button.Enabled = !drink_2_button.Enabled;
            drink_4_button.Enabled = !drink_4_button.Enabled;
        }

        public void write_price(int money)
        {
            price_Drink = money;
            price_Drinks = money;
        }

        public void pay(int grn)
        {
            drink_choice.BackColor = Color.White;
            money.BackColor = Color.Green;
            cup.Visible = true;
            tips.Text = $"Внесіть кошти :{price_Drink} грн";
            grn_1.Enabled = grn_10.Enabled = grn_100.Enabled = grn_1000.Enabled = grn_2.Enabled =
            grn_20.Enabled = grn_200.Enabled = grn_5.Enabled = grn_50.Enabled = grn_500.Enabled =
            card.Enabled = true;
            price_Drink -= grn;
            if (price_Drink > 0)
            {
                tips.Text = $"Залишилося ще:{price_Drink}грн";
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
            string x = $"Вартість = {price_Drinks} \nРешта = {-price_Drink}  \nДата купівлі :{date}";
            MessageBox.Show(x, "chek") ;
            // MessageBox.Show("Время вышло1");
            check.BackColor = Color.White;
            drink_1_button.BackColor = Color.White;
            drink_3_button.BackColor = Color.White;
            drink_2_button.BackColor = Color.White;
            drink_4_button.BackColor = Color.White;
            drink_choice.BackColor = Color.Green;
            check_button.Enabled = false;
            check_button.Visible = false;
            tips.Text = "Виберіть свій напій";
            enabled_button();
        }

        private void add_drink_button_Click(object sender, EventArgs e)
        {

            try
            {
                id_drink = int.Parse(drink_id.Text);
                name_drink = drink_name.Text;
                portion_drink = int.Parse(drink_portion.Text);
                price_drink = int.Parse(drink_price.Text);

                add_drink(id_drink, name_drink, portion_drink, price_drink);
            }
            catch//(Exception)
            {

                if(id_drink==default||name_drink==null||portion_drink==default || price_drink==default)
                {
                    MessageBox.Show("Не правильно заповнені поля");
                }              

            }
        }

        private void add_machine_componet_button_Click(object sender, EventArgs e)
        {

            try
            {
                id_mc = int.Parse(machine_componets_id.Text);
                check_paper_mc = int.Parse(check_paper.Text);
                cups_mc = int.Parse(cups.Text);
                sugar_mc = int.Parse(sugar.Text);
                add_mc(id_mc,check_paper_mc,cups_mc,sugar_mc);

            }
            catch//(Exception)
            {
                if(id_mc==default||check_paper_mc==default||cups_mc==default||sugar_mc==default)
                {
                    MessageBox.Show("Не правильно заповнені поля");
                }

            }
        }

        private void add_machine_button_Click(object sender, EventArgs e)
        {
            try
            {
                id_machine=int.Parse(machine_id.Text);
                id_mc_ma = int.Parse(mc_ma_id.Text);
                id_drink_1_ma = int.Parse(drink_1_id.Text);
                id_drink_2_ma = int.Parse(drink_2_id.Text);
                id_drink_3_ma = int.Parse(drink_3_id.Text);
                id_drink_4_ma = int.Parse(drink_4_id.Text);
                add_machine(id_machine,id_mc_ma,id_drink_1_ma,id_drink_2_ma,id_drink_3_ma,id_drink_4_ma);
            }
            catch
            {
                if(id_machine==default||id_mc_ma==default||id_drink_1_ma==default||id_drink_2_ma==default||id_drink_3_ma==default||id_drink_4_ma==default)
                {
                    MessageBox.Show("Не правильно заповнені поля");
                }
            }

        }


        private void check_button_Click(object sender, EventArgs e)
        {
            chek();
        }
               
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