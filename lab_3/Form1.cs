namespace lab_3
{
    public partial class Form1 : Form
    {
        public int price_Drink;
        public int price_Drinks;

        TimeSpan totalTime;
        DateTime date;

        public int drinks;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            drink_choice.BackColor = Color.Green;
            using var db = new MachineContext(); 
             update_list_drink();
             update_list_mc();
             update_list_ma();
            initiation_button();
          //  num_ma_text.Text = ma_num.ToString();           
        }

        public void initiation_button()
        {
            using var db = new MachineContext();
            var ma = db.Machines.First();
            var drink_1 = db.Drinks.Find(ma.Drink_1);
            var drink_2 = db.Drinks.Find(ma.Drink_2);
            var drink_3 = db.Drinks.Find(ma.Drink_3);
            var drink_4 = db.Drinks.Find(ma.Drink_4);
            drink_1_button.Text = drink_1.Name_Drink;
            drink_2_button.Text = drink_2.Name_Drink;
            drink_3_button.Text = drink_3.Name_Drink;
            drink_4_button.Text = drink_4.Name_Drink;
            drink_button_on();

            drink_choice.BackColor = Color.Green;
            money.BackColor=Color.White;
            tips.Text = "Виберіть свій напій";
          //  num_ma_text.Text = ma_num.ToString();
            money_button_off();
        }

        private void drink_button_on()
        {
            drink_1_button.Enabled = drink_2_button.Enabled = drink_3_button.Enabled =
                drink_4_button.Enabled = true;
            drink_1_button.BackColor= drink_2_button.BackColor =
                drink_3_button.BackColor = drink_4_button.BackColor = Color.White;
        }

        private void drink_button_off()
        {
            drink_1_button.Enabled = drink_2_button.Enabled = drink_3_button.Enabled =
    drink_4_button.Enabled = false;
        }

        private void push_button_drink(int drink_id )
        {
            using var db = new MachineContext();
            var ma = db.Machines.First();
            var drink = db.Drinks.Find(drink_id);
            var mc = db.Components.Find(ma.Machine_components);
            if(mc.Cups==0)
            { 
                tips.Text = $"Нажаль чашок не має";
                drink_button_on();
               
            }
           else
            {
                if(mc.CheckPaper==0)
                {
                    // enabled_button();
                    drink_button_on();
                    tips.Text = $"Нажаль чеків не має";
                }
                else
                {
                    if(mc.Sugar==0)
                    {
                        tips.Text = $"Нажаль цукру не має";
                        drink_button_on();

                    }
                    else
                    {
                        price_Drink = drink.Price_Drink;
                        pay(0);
                      
                    }

                }
            }
            
        }

        private void drink_1_button_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            var ma = db.Machines.First();
            var drink_1 = db.Drinks.Find(ma.Drink_1);
            drinks = drink_1.DrinkId;
            if(drink_1.Portion_Drink>=1)
            {
            drink_1_button.BackColor = Color.Green;
                // enabled_button();
                drink_button_off();
            push_button_drink(ma.Drink_1);
            }
            else
            {
                tips.Text = "Напій закінчився";
                drink_1_button.BackColor = Color.Red;
            }
        }

        private void drink_2_button_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            var ma = db.Machines.First();
            var drink_2 = db.Drinks.Find(ma.Drink_2);
            drinks = drink_2.DrinkId;
            if (drink_2.Portion_Drink >= 1)
            {
                drink_2_button.BackColor = Color.Green;
                drink_button_off();
                push_button_drink(ma.Drink_2);
            }
            else
            {
                tips.Text = "Напій закінчився";
                drink_2_button.BackColor = Color.Red;
            }
        }

        private void drink_3_button_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            var ma = db.Machines.First() ;
            var drink_3 = db.Drinks.Find(ma.Drink_3);
            drinks = drink_3.DrinkId;
            if (drink_3.Portion_Drink >= 1)
            {
                drink_3_button.BackColor = Color.Green;
                drink_button_off();
                push_button_drink(ma.Drink_3);
            }
            else
            {
                tips.Text = "Напій закінчився";
                drink_3_button.BackColor = Color.Red;
            }
        }
        
        private void drink_4_button_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            var ma = db.Machines.First();
            var drink_4 = db.Drinks.Find(ma.Drink_4);
            drinks = drink_4.DrinkId;
            if (drink_4.Portion_Drink >= 1)
            {
                drink_4_button.BackColor = Color.Green;
                drink_button_off();
                push_button_drink(ma.Drink_4);
            }
            else
            {
                tips.Text = "Напій закінчився";
                drink_4_button.BackColor = Color.Red;
            }
        }

        public void pay(int grn)
        {
            drink_choice.BackColor = Color.White;
            money.BackColor = Color.Green;
            cup.Visible = true;
            tips.Text = $"Внесіть кошти :{price_Drink} грн";
            money_button_on();
            price_Drink -= grn;
            if (price_Drink > 0)
            {
                tips.Text = $"Залишилося ще:{price_Drink}грн";
            }
            else
            {
                money_button_off();
                money.BackColor = Color.White;
                proces();
            }
        }

        public void proces()
        {
            date = DateTime.Now;

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
            using var db = new MachineContext();
            var ma = db.Machines.First();
            var drink = db.Drinks.Find(drinks);
            var mc = db.Components.Find(ma.Machine_components);

            mc.Sugar = mc.Sugar - 1;
            mc.CheckPaper= mc.CheckPaper-1;
            mc.Cups= mc.Cups-1;
            drink.Portion_Drink = drink.Portion_Drink-1;

            string x = $"Вартість = {drink.Price_Drink} \nРешта = {-price_Drink}  \nДата купівлі :{date}";
            MessageBox.Show(x, "chek") ;
            db.SaveChanges();
            update_list_drink();
            update_list_mc();
            drink_button_on();
            check.BackColor = Color.White;
            drink_choice.BackColor = Color.Green;
            check_button.Enabled = false;
            check_button.Visible = false;
            tips.Text = "Виберіть свій напій";            
        }
            
        private void money_button_on()
        {
            grn_1.Enabled = grn_10.Enabled = grn_2.Enabled =
            grn_20.Enabled = grn_5.Enabled = grn_50.Enabled = true;
        }  
        
        private void money_button_off()
        {
            grn_1.Enabled = grn_10.Enabled = grn_2.Enabled =
            grn_20.Enabled = grn_5.Enabled = grn_50.Enabled = false;

        }

        private void check_button_Click(object sender, EventArgs e)
        {
            chek();
        }
               
        private void grn_1_Click(object sender, EventArgs e)
        {//card.Enabled = false;
            pay(1);
        }

        private void grn_2_Click(object sender, EventArgs e)
        {//card.Enabled = false;
            pay(2);
        }

        private void grn_5_Click(object sender, EventArgs e)
        {//card.Enabled = false;
            pay(5);
        }

        private void grn_10_Click(object sender, EventArgs e)
        {//card.Enabled = false;
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

        private void cancell_Click(object sender, EventArgs e)
        {
            initiation_button();
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show(this);
        }
    }
}