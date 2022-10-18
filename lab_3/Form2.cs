using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            update_list_drink();
            update_list_ma();
            update_list_mc();
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        private void add_drink_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (drink_name.Text.Length != 0)
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

                if (drink_id.Text.Length == 0 || drink_portion.Text.Length == 0 || drink_price.Text.Length
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

        private void update_drink_button_Click(object sender, EventArgs e)
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
                if (drink_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле ID обов'язково має бути заповненим ");
                }

            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////
        private void add_machine_componet_button_Click(object sender, EventArgs e)
        {
            try
            {
                add_mc(int.Parse(machine_componets_id.Text), int.Parse(check_paper.Text), int.Parse(cups.Text),
                   int.Parse(sugar.Text));
            }
            catch
            {
                if (machine_componets_id.Text.Length == 0 || check_paper.Text.Length == 0
                    || cups.Text.Length == 0 || sugar.Text.Length == 0)
                {
                    MessageBox.Show("Не заповнені всі поля");
                }
                else
                {
                    MessageBox.Show("Не правильно заповнені поля");
                }

            }
        }

        private void update_mc_button_Click(object sender, EventArgs e)
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

        ////////////////////////////////////////////////////////////////////////////////////////
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

        private void update_ma_button_Click(object sender, EventArgs e)
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
                if (ma.Drink_1 == ma.Drink_2 || ma.Drink_1 == ma.Drink_3 || ma.Drink_1 == ma.Drink_4 ||
                    ma.Drink_2 == ma.Drink_3 || ma.Drink_2 == ma.Drink_4 || ma.Drink_3 == ma.Drink_4)
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

        ////////////////////////////////////////////////////////////////////////////////////////

        public void add_drink(int id, string name, int portion, int price)
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

        public void add_mc(int id, int check_paper, int cups, int sugar)
        {
            using var db = new MachineContext();
            var mc = new Machine_component
            {
                Machine_componentId = id,
                Sugar = sugar,
                CheckPaper = check_paper,
                Cups = cups,
            };
            db.Add(mc);
            db.SaveChanges();
            update_list_mc();
        }

        public void add_machine(int id, int id_mc, int drink_1, int drink_2, int drink_3, int drink_4)
        {
            using var db = new MachineContext();
            var mc = new Machine
            {
                MachineId = id,
                Machine_components = id_mc,
                Drink_1 = drink_1,
                Drink_2 = drink_2,
                Drink_3 = drink_3,
                Drink_4 = drink_4,
            };
            db.Add(mc);
            db.SaveChanges();
            update_list_ma();
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////
        public void update_list_drink()
        {
            drinks_list.Items.Clear();
            using var db = new MachineContext();
            foreach (var item in db.Drinks)
            {
                drinks_list.Items.Add(item.DrinkId + " " + item.Name_Drink
                    + " " + item.Portion_Drink + " " + item.Price_Drink);
            }
        }

        public void update_list_mc()
        {
            mc_list.Items.Clear();
            using var db = new MachineContext();
            foreach (var item in db.Components)
            {
                mc_list.Items.Add(item.Machine_componentId + " " + item.CheckPaper
                    + " " + item.Cups + " " + item.Sugar);
            }
        }

        public void update_list_ma()
        {
            ma_list.Items.Clear();
            using var db = new MachineContext();

            foreach (var item in db.Machines)
            {
                ma_list.Items.Add(item.MachineId + " " + item.Machine_components + " " + item.Drink_1
                    + " " + item.Drink_2 + " " + item.Drink_3 + " " + item.Drink_4);
            }


        }

    }
}
