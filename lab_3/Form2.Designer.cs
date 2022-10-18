namespace lab_3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.del_drink = new System.Windows.Forms.Button();
            this.update_drink_button = new System.Windows.Forms.Button();
            this.drinks_list = new System.Windows.Forms.ListBox();
            this.add_drink_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drink_price = new System.Windows.Forms.TextBox();
            this.drink_portion = new System.Windows.Forms.TextBox();
            this.drink_name = new System.Windows.Forms.TextBox();
            this.drink_id = new System.Windows.Forms.TextBox();
            this.del_ma = new System.Windows.Forms.Button();
            this.del_mc = new System.Windows.Forms.Button();
            this.update_ma_button = new System.Windows.Forms.Button();
            this.update_mc_button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mc_ma_id = new System.Windows.Forms.TextBox();
            this.machine_id = new System.Windows.Forms.TextBox();
            this.ma_list = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.add_machine_button = new System.Windows.Forms.Button();
            this.drink_4_id = new System.Windows.Forms.TextBox();
            this.drink_3_id = new System.Windows.Forms.TextBox();
            this.drink_2_id = new System.Windows.Forms.TextBox();
            this.drink_1_id = new System.Windows.Forms.TextBox();
            this.mc_list = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.add_machine_componet_button = new System.Windows.Forms.Button();
            this.sugar = new System.Windows.Forms.TextBox();
            this.cups = new System.Windows.Forms.TextBox();
            this.check_paper = new System.Windows.Forms.TextBox();
            this.machine_componets_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // del_drink
            // 
            this.del_drink.Location = new System.Drawing.Point(759, 177);
            this.del_drink.Name = "del_drink";
            this.del_drink.Size = new System.Drawing.Size(113, 52);
            this.del_drink.TabIndex = 86;
            this.del_drink.Text = "видалити напій";
            this.del_drink.UseVisualStyleBackColor = true;
            this.del_drink.Click += new System.EventHandler(this.del_drink_Click);
            // 
            // update_drink_button
            // 
            this.update_drink_button.Location = new System.Drawing.Point(759, 108);
            this.update_drink_button.Name = "update_drink_button";
            this.update_drink_button.Size = new System.Drawing.Size(113, 52);
            this.update_drink_button.TabIndex = 85;
            this.update_drink_button.Text = "редагувати напій";
            this.update_drink_button.UseVisualStyleBackColor = true;
            this.update_drink_button.Click += new System.EventHandler(this.update_drink_button_Click);
            // 
            // drinks_list
            // 
            this.drinks_list.FormattingEnabled = true;
            this.drinks_list.ItemHeight = 20;
            this.drinks_list.Location = new System.Drawing.Point(223, 108);
            this.drinks_list.Name = "drinks_list";
            this.drinks_list.Size = new System.Drawing.Size(518, 144);
            this.drinks_list.TabIndex = 84;
            // 
            // add_drink_button
            // 
            this.add_drink_button.Location = new System.Drawing.Point(759, 33);
            this.add_drink_button.Name = "add_drink_button";
            this.add_drink_button.Size = new System.Drawing.Size(113, 52);
            this.add_drink_button.TabIndex = 83;
            this.add_drink_button.Text = "додати напій";
            this.add_drink_button.UseVisualStyleBackColor = true;
            this.add_drink_button.Click += new System.EventHandler(this.add_drink_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "Ціна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "Порцій";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "id";
            // 
            // drink_price
            // 
            this.drink_price.Location = new System.Drawing.Point(616, 58);
            this.drink_price.Name = "drink_price";
            this.drink_price.Size = new System.Drawing.Size(125, 27);
            this.drink_price.TabIndex = 78;
            // 
            // drink_portion
            // 
            this.drink_portion.Location = new System.Drawing.Point(485, 58);
            this.drink_portion.Name = "drink_portion";
            this.drink_portion.Size = new System.Drawing.Size(125, 27);
            this.drink_portion.TabIndex = 77;
            // 
            // drink_name
            // 
            this.drink_name.Location = new System.Drawing.Point(354, 58);
            this.drink_name.Name = "drink_name";
            this.drink_name.Size = new System.Drawing.Size(125, 27);
            this.drink_name.TabIndex = 76;
            // 
            // drink_id
            // 
            this.drink_id.Location = new System.Drawing.Point(223, 58);
            this.drink_id.Name = "drink_id";
            this.drink_id.Size = new System.Drawing.Size(125, 27);
            this.drink_id.TabIndex = 75;
            // 
            // del_ma
            // 
            this.del_ma.Location = new System.Drawing.Point(759, 672);
            this.del_ma.Name = "del_ma";
            this.del_ma.Size = new System.Drawing.Size(113, 52);
            this.del_ma.TabIndex = 114;
            this.del_ma.Text = "видалити автомат";
            this.del_ma.UseVisualStyleBackColor = true;
            this.del_ma.Click += new System.EventHandler(this.del_ma_Click);
            // 
            // del_mc
            // 
            this.del_mc.Location = new System.Drawing.Point(759, 427);
            this.del_mc.Name = "del_mc";
            this.del_mc.Size = new System.Drawing.Size(113, 52);
            this.del_mc.TabIndex = 113;
            this.del_mc.Text = "видалити розхідники";
            this.del_mc.UseVisualStyleBackColor = true;
            this.del_mc.Click += new System.EventHandler(this.del_mc_Click);
            // 
            // update_ma_button
            // 
            this.update_ma_button.Location = new System.Drawing.Point(759, 604);
            this.update_ma_button.Name = "update_ma_button";
            this.update_ma_button.Size = new System.Drawing.Size(113, 52);
            this.update_ma_button.TabIndex = 112;
            this.update_ma_button.Text = "оновити автомат";
            this.update_ma_button.UseVisualStyleBackColor = true;
            this.update_ma_button.Click += new System.EventHandler(this.update_ma_button_Click);
            // 
            // update_mc_button
            // 
            this.update_mc_button.Location = new System.Drawing.Point(759, 350);
            this.update_mc_button.Name = "update_mc_button";
            this.update_mc_button.Size = new System.Drawing.Size(113, 52);
            this.update_mc_button.TabIndex = 111;
            this.update_mc_button.Text = "редагувати розхідники";
            this.update_mc_button.UseVisualStyleBackColor = true;
            this.update_mc_button.Click += new System.EventHandler(this.update_mc_button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 110;
            this.label15.Text = "розхідники";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 516);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 20);
            this.label16.TabIndex = 109;
            this.label16.Text = "id";
            // 
            // mc_ma_id
            // 
            this.mc_ma_id.Location = new System.Drawing.Point(306, 561);
            this.mc_ma_id.Name = "mc_ma_id";
            this.mc_ma_id.Size = new System.Drawing.Size(83, 27);
            this.mc_ma_id.TabIndex = 108;
            // 
            // machine_id
            // 
            this.machine_id.Location = new System.Drawing.Point(217, 561);
            this.machine_id.Name = "machine_id";
            this.machine_id.Size = new System.Drawing.Size(83, 27);
            this.machine_id.TabIndex = 107;
            // 
            // ma_list
            // 
            this.ma_list.FormattingEnabled = true;
            this.ma_list.ItemHeight = 20;
            this.ma_list.Location = new System.Drawing.Point(223, 604);
            this.ma_list.Name = "ma_list";
            this.ma_list.Size = new System.Drawing.Size(518, 144);
            this.ma_list.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(670, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 105;
            this.label11.Text = "напій 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(587, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 104;
            this.label12.Text = "напій 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(498, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 103;
            this.label13.Text = "напій 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 102;
            this.label14.Text = "напій 1";
            // 
            // add_machine_button
            // 
            this.add_machine_button.Location = new System.Drawing.Point(759, 536);
            this.add_machine_button.Name = "add_machine_button";
            this.add_machine_button.Size = new System.Drawing.Size(113, 52);
            this.add_machine_button.TabIndex = 101;
            this.add_machine_button.Text = "додати автомати";
            this.add_machine_button.UseVisualStyleBackColor = true;
            this.add_machine_button.Click += new System.EventHandler(this.add_machine_button_Click);
            // 
            // drink_4_id
            // 
            this.drink_4_id.Location = new System.Drawing.Point(662, 561);
            this.drink_4_id.Name = "drink_4_id";
            this.drink_4_id.Size = new System.Drawing.Size(83, 27);
            this.drink_4_id.TabIndex = 100;
            // 
            // drink_3_id
            // 
            this.drink_3_id.Location = new System.Drawing.Point(573, 561);
            this.drink_3_id.Name = "drink_3_id";
            this.drink_3_id.Size = new System.Drawing.Size(83, 27);
            this.drink_3_id.TabIndex = 99;
            // 
            // drink_2_id
            // 
            this.drink_2_id.Location = new System.Drawing.Point(484, 561);
            this.drink_2_id.Name = "drink_2_id";
            this.drink_2_id.Size = new System.Drawing.Size(83, 27);
            this.drink_2_id.TabIndex = 98;
            // 
            // drink_1_id
            // 
            this.drink_1_id.Location = new System.Drawing.Point(395, 561);
            this.drink_1_id.Name = "drink_1_id";
            this.drink_1_id.Size = new System.Drawing.Size(83, 27);
            this.drink_1_id.TabIndex = 97;
            // 
            // mc_list
            // 
            this.mc_list.FormattingEnabled = true;
            this.mc_list.ItemHeight = 20;
            this.mc_list.Location = new System.Drawing.Point(223, 350);
            this.mc_list.Name = "mc_list";
            this.mc_list.Size = new System.Drawing.Size(518, 144);
            this.mc_list.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 95;
            this.label7.Text = "Порцій цукру";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 94;
            this.label8.Text = "Стаканчики";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 93;
            this.label9.Text = "Папір для чеків";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 92;
            this.label10.Text = "id";
            // 
            // add_machine_componet_button
            // 
            this.add_machine_componet_button.Location = new System.Drawing.Point(759, 282);
            this.add_machine_componet_button.Name = "add_machine_componet_button";
            this.add_machine_componet_button.Size = new System.Drawing.Size(113, 52);
            this.add_machine_componet_button.TabIndex = 91;
            this.add_machine_componet_button.Text = "додати розхідники";
            this.add_machine_componet_button.UseVisualStyleBackColor = true;
            this.add_machine_componet_button.Click += new System.EventHandler(this.add_machine_componet_button_Click);
            // 
            // sugar
            // 
            this.sugar.Location = new System.Drawing.Point(616, 307);
            this.sugar.Name = "sugar";
            this.sugar.Size = new System.Drawing.Size(125, 27);
            this.sugar.TabIndex = 90;
            // 
            // cups
            // 
            this.cups.Location = new System.Drawing.Point(485, 307);
            this.cups.Name = "cups";
            this.cups.Size = new System.Drawing.Size(125, 27);
            this.cups.TabIndex = 89;
            // 
            // check_paper
            // 
            this.check_paper.Location = new System.Drawing.Point(354, 307);
            this.check_paper.Name = "check_paper";
            this.check_paper.Size = new System.Drawing.Size(125, 27);
            this.check_paper.TabIndex = 88;
            // 
            // machine_componets_id
            // 
            this.machine_componets_id.Location = new System.Drawing.Point(223, 307);
            this.machine_componets_id.Name = "machine_componets_id";
            this.machine_componets_id.Size = new System.Drawing.Size(125, 27);
            this.machine_componets_id.TabIndex = 87;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 767);
            this.Controls.Add(this.del_ma);
            this.Controls.Add(this.del_mc);
            this.Controls.Add(this.update_ma_button);
            this.Controls.Add(this.update_mc_button);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mc_ma_id);
            this.Controls.Add(this.machine_id);
            this.Controls.Add(this.ma_list);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.add_machine_button);
            this.Controls.Add(this.drink_4_id);
            this.Controls.Add(this.drink_3_id);
            this.Controls.Add(this.drink_2_id);
            this.Controls.Add(this.drink_1_id);
            this.Controls.Add(this.mc_list);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.add_machine_componet_button);
            this.Controls.Add(this.sugar);
            this.Controls.Add(this.cups);
            this.Controls.Add(this.check_paper);
            this.Controls.Add(this.machine_componets_id);
            this.Controls.Add(this.del_drink);
            this.Controls.Add(this.update_drink_button);
            this.Controls.Add(this.drinks_list);
            this.Controls.Add(this.add_drink_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drink_price);
            this.Controls.Add(this.drink_portion);
            this.Controls.Add(this.drink_name);
            this.Controls.Add(this.drink_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button del_drink;
        private Button update_drink_button;
        private ListBox drinks_list;
        private Button add_drink_button;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox drink_price;
        private TextBox drink_portion;
        private TextBox drink_name;
        private TextBox drink_id;
        private Button del_ma;
        private Button del_mc;
        private Button update_ma_button;
        private Button update_mc_button;
        private Label label15;
        private Label label16;
        private TextBox mc_ma_id;
        private TextBox machine_id;
        private ListBox ma_list;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button add_machine_button;
        private TextBox drink_4_id;
        private TextBox drink_3_id;
        private TextBox drink_2_id;
        private TextBox drink_1_id;
        private ListBox mc_list;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button add_machine_componet_button;
        private TextBox sugar;
        private TextBox cups;
        private TextBox check_paper;
        private TextBox machine_componets_id;
    }
}