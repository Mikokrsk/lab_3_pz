namespace lab_3
{
    public partial class Form1 : Form
    {
        public int price_Drink;
        public int price_Drinks;
        //public int price_coffee = 25;
        //public int price_tea = 15;
        //public int price_cacao = 17;
        //public int price_chocolate = 20;

        TimeSpan totalTime;
        DateTime date;

        public int ma_num=1;
        public int drinks;
        //public string name_drink;
        //public int portion_drink;
        //public int price_drink;

        //public int id_mc;
        //public int check_paper_mc;
        //public int cups_mc;
        //public int sugar_mc;

        //public int id_machine;
        //public int id_mc_ma;
        //public int id_drink_1_ma;
        //public int id_drink_2_ma;
        //public int id_drink_3_ma;
        //public int id_drink_4_ma;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            drink_choice.BackColor = Color.Green;
            //////////////////////////////////////
            using var db = new MachineContext();
          //  var ma = db.Machines.Find(ma_num);
          //  var drink = db.Drinks.Find(drink_id);
           // var mc = db.Components.Find(ma.Machine_components);
             
             update_list_drink();
             update_list_mc();
             update_list_ma();
            // step_1();
            initiation_button(ma_num);
            num_ma_text.Text = ma_num.ToString();
            //using var db = new MachineContext();
           
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
            update_list_mc();
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

        private void del_drink_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            try
            {
                db.Remove(db.Drinks.Find(int.Parse(drink_id.Text)));
                db.SaveChanges();
                update_list_drink();
            }
            catch
            {
                if(drink_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
                }

            }
        }

        private void del_mc_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            try
            {
                db.Remove(db.Components.Find(int.Parse(machine_componets_id.Text)));
                db.SaveChanges();
                update_list_mc();
            }
            catch
            {
                if (machine_componets_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
                }

            }
        }

        private void del_ma_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            try
            {
                db.Remove(db.Machines.Find(int.Parse(machine_id.Text)));
                db.SaveChanges();
                update_list_ma();
            }
            catch
            {
                if (machine_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
                }

            }
        }

        private void add_drink_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(drink_name.Text.Length!=0)
                {
                add_drink(int.Parse(drink_id.Text), drink_name.Text, int.Parse(drink_portion.Text),
                    int.Parse(drink_price.Text));
                }
                else
                {
                    MessageBox.Show("Не заповнені поля");
                }
            }
            catch
            {
             
                if (drink_id.Text.Length ==0 ||  drink_portion.Text.Length == 0 || drink_price.Text.Length 
                    == 0)
                {
                    MessageBox.Show("Не заповнені поля");
                }
                else
                {
                    MessageBox.Show("Не правильно заповнені поля");
                }
            }
        }

        private void add_machine_componet_button_Click(object sender, EventArgs e)
        {

            try
            { 
                add_mc(int.Parse(machine_componets_id.Text), int.Parse(check_paper.Text), int.Parse(cups.Text),
                   int.Parse(sugar.Text));
            }
            catch
            {
                if(machine_componets_id.Text.Length == 0 || check_paper.Text.Length==0
                    ||cups.Text.Length==0||sugar.Text.Length==0)
                {
                    MessageBox.Show("Не заповнені всі поля");
                }
                else
                {
                    MessageBox.Show("Не правильно заповнені поля");
                }

            }
        }

        private void add_machine_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (drink_1_id.Text.Length == 0 || drink_2_id.Text.Length == 0 || drink_3_id.Text.Length == 0
                    || drink_4_id.Text.Length == 0 || mc_ma_id.Text.Length == 0 || machine_id.Text.Length == 0)
                {
                    MessageBox.Show("Не заповнені поля");
                }
                else
                {
                    if (drink_1_id.Text == drink_2_id.Text || drink_1_id.Text == drink_3_id.Text
                        || drink_1_id.Text == drink_4_id.Text || drink_2_id.Text == drink_3_id.Text
                        || drink_2_id.Text == drink_4_id.Text || drink_3_id.Text == drink_4_id.Text)
                    {
                        MessageBox.Show("Напої повині бути різні");
                    }
                    else
                    {
                        add_machine(int.Parse(machine_id.Text), int.Parse(mc_ma_id.Text), int.Parse(drink_1_id.Text),
                        int.Parse(drink_2_id.Text), int.Parse(drink_3_id.Text), int.Parse(drink_4_id.Text));
                    }
                }
            }
            catch
            {
                
                    MessageBox.Show("Не правильно заповнені поля");
                
            }

        }

        private void update_drink_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();

            try
            {
                    var drink = db.Drinks.Find(int.Parse(drink_id.Text));
                    if (drink_name.Text.Length == 0)
                    {
                        drink.Name_Drink = drink.Name_Drink;
                    }
                    else
                    {
                        drink.Name_Drink = drink_name.Text;
                    }

                    try
                    {
                        drink.Portion_Drink = int.Parse(drink_portion.Text);
                    }
                    catch
                    {
                        drink.Portion_Drink = drink.Portion_Drink;
                    }

                    try
                    {
                        drink.Price_Drink = int.Parse(drink_price.Text);
                    }
                    catch
                    {
                        drink.Price_Drink = drink.Price_Drink;
                    }
                    db.Update(drink);
                    db.SaveChanges();
                    update_list_drink();
            }
            catch
            {
                if (drink_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
                }
            }
                       
        }

        private void update_mc_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            try
            {
                var mc = db.Components.Find(int.Parse(machine_componets_id.Text));
                try
                {
                    mc.CheckPaper = int.Parse(check_paper.Text);
                }
                catch
                {
                    mc.CheckPaper = mc.CheckPaper;
                }
                try
                {
                    mc.Cups = int.Parse(cups.Text);
                }
                catch
                {
                    mc.Cups = mc.Cups;

                }
                try
                {
                    mc.Sugar = int.Parse(sugar.Text);
                }
                catch
                {
                    mc.Sugar = mc.Sugar;
                }

                db.Update(mc);
                db.SaveChanges();
                update_list_mc();
            }
            catch
            {
                if (machine_componets_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
                }
            }

        }

        private void update_ma_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new MachineContext();
                var ma = db.Machines.Find(int.Parse(machine_id.Text));
                ma.MachineId = int.Parse(machine_id.Text);
                try
                {
                    ma.Machine_components = int.Parse(mc_ma_id.Text);
                }
                catch
                {
                    ma.Machine_components = ma.Machine_components;
                }

                try
                {
                    ma.Drink_1 = int.Parse(drink_1_id.Text);
                }
                catch
                {
                    ma.Drink_1 = ma.Drink_1;
                }
                try
                {
                    ma.Drink_2 = int.Parse(drink_2_id.Text);
                }
                catch
                {
                    ma.Drink_2 = ma.Drink_2;
                }
                try
                {
                    ma.Drink_3 = int.Parse(drink_3_id.Text);
                }
                catch
                {
                    ma.Drink_3 = ma.Drink_3;
                }
                try
                {
                    ma.Drink_4 = int.Parse(drink_4_id.Text);
                }
                catch
                {
                    ma.Drink_4 = ma.Drink_4;
                }
                if(ma.Drink_1==ma.Drink_2||ma.Drink_1==ma.Drink_3||ma.Drink_1==ma.Drink_4||
                    ma.Drink_2==ma.Drink_3||ma.Drink_2==ma.Drink_4||ma.Drink_3==ma.Drink_4)
                {
                    MessageBox.Show("Напої мають бути різні");
                }
                else
                {
                db.Update(ma);
                db.SaveChanges();
                update_list_ma();
                }
                
            }
            catch
            {
                MessageBox.Show("Поле ID обов'язково має бути заповненим ");
            }
 
        }

        public void initiation_button(int ma_num=1)
        {
            using var db = new MachineContext();
            var ma = db.Machines.Find(ma_num);
            var drink_1 = db.Drinks.Find(ma.Drink_1);
            var drink_2 = db.Drinks.Find(ma.Drink_2);
            var drink_3 = db.Drinks.Find(ma.Drink_3);
            var drink_4 = db.Drinks.Find(ma.Drink_4);
            drink_1_button.Text = drink_1.Name_Drink;
            drink_2_button.Text = drink_2.Name_Drink;
            drink_3_button.Text = drink_3.Name_Drink;
            drink_4_button.Text = drink_4.Name_Drink;
            drink_1_button.Enabled = true;
            drink_2_button.Enabled = true;
            drink_3_button.Enabled = true;
            drink_4_button.Enabled = true;
            drink_1_button.BackColor = Color.White;
            drink_2_button.BackColor = Color.White;
            drink_3_button.BackColor = Color.White;
            drink_4_button.BackColor = Color.White;
            drink_choice.BackColor = Color.Green;
            tips.Text = "Виберіть свій напій";
            num_ma_text.Text = ma_num.ToString();
        }

        public void push_button_drink(int drink_id )
        {
            using var db = new MachineContext();
            var ma = db.Machines.Find(ma_num);
            var drink = db.Drinks.Find(drink_id);
            var mc = db.Components.Find(ma.Machine_components);
            if(mc.Cups==0)
            { 
                tips.Text = $"Нажаль чашок не має";
                enabled_button();
               
            }
           else
            {
                if(mc.CheckPaper==0)
                {
                    enabled_button();
                    tips.Text = $"Нажаль чеків не має";
                }
                else
                {
                    if(mc.Sugar==0)
                    {
                        tips.Text = $"Нажаль цукру не має";
                        enabled_button();
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
            var ma = db.Machines.Find(ma_num);
            var drink_1 = db.Drinks.Find(ma.Drink_1);
            drinks = drink_1.DrinkId;
            if(drink_1.Portion_Drink>=1)
            {
            drink_1_button.BackColor = Color.Green;
            enabled_button();
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
            var ma = db.Machines.Find(ma_num);
            var drink_2 = db.Drinks.Find(ma.Drink_2);
            drinks = drink_2.DrinkId;
            if (drink_2.Portion_Drink >= 1)
            {
                drink_2_button.BackColor = Color.Green;
                enabled_button();
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
            var ma = db.Machines.Find(ma_num);
            var drink_3 = db.Drinks.Find(ma.Drink_3);
            drinks = drink_3.DrinkId;
            if (drink_3.Portion_Drink >= 1)
            {
                drink_3_button.BackColor = Color.Green;
                enabled_button();
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
            var ma = db.Machines.Find(ma_num);
            var drink_4 = db.Drinks.Find(ma.Drink_4);
            drinks = drink_4.DrinkId;
            if (drink_4.Portion_Drink >= 1)
            {
                drink_4_button.BackColor = Color.Green;
                enabled_button();
                push_button_drink(ma.Drink_4);
            }
            else
            {
                tips.Text = "Напій закінчився";
                drink_4_button.BackColor = Color.Red;
            }
        }

        public void enabled_button()
        {
            drink_1_button.Enabled = !drink_1_button.Enabled;
            drink_3_button.Enabled = !drink_3_button.Enabled;
            drink_2_button.Enabled = !drink_2_button.Enabled;
            drink_4_button.Enabled = !drink_4_button.Enabled;
        }

        public void pay(int grn)
        {
            if (grn == -1)
            {
                initiation_button(ma_num);
            }

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
               // date = DateTime.Now;
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
            var ma = db.Machines.Find(ma_num);
            var drink = db.Drinks.Find(drinks);
            var mc = db.Components.Find(ma.Machine_components);

            mc.Sugar = mc.Sugar - 1;
            mc.CheckPaper= mc.CheckPaper-1;
            mc.Cups= mc.Cups-1;
            drink.Portion_Drink = drink.Portion_Drink-1;

         // int d= drink.Price_Drink;
            string x = $"Вартість = {drink.Price_Drink} \nРешта = {-price_Drink}  \nДата купівлі :{date}";
            MessageBox.Show(x, "chek") ;
           // db.Update(drink);
          //  db.Update(db.Components);
            //db.Update(db.Drinks);
            db.SaveChanges();
            update_list_drink();
            update_list_mc();
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

        private void switch_ma_Click(object sender, EventArgs e)
        {
            using var db = new MachineContext();
            try
            {
                ma_num = int.Parse(num_ma.Text);  
                try
                 {
                var ma = db.Machines.Find(int.Parse(num_ma.Text));
                initiation_button(ma_num);
                 }
                 catch
                 {
                MessageBox.Show($"Не має апарату : {num_ma.Text}");
                 }          
            }
            catch
            {
                if(num_ma.Text.Length==0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
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