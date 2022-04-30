using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGTest_Winform
{
    public partial class Form1 : Form
    {
        
        float money = 100000;
        float price_dice = 20;
        bool monster_spawned = false;
        int dice_damagelimit = 6;
        int dice = 0;
        int exp;
        int levels = 1;
        string dollarsign = "$";
        string buydice = "Buy Dice";
        string space = " ";
        string disabled = "Disabled";
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = levels.ToString();
            label3.Text = dice.ToString();
            button2.Text = buydice + space + price_dice + dollarsign;
        }
        //roll
        private void button1_Click(object sender, EventArgs e)
        {
            dice_damagelimit = dice_damagelimit * dice;
            int dicedamage = rand.Next(dice, dice_damagelimit);   
            label6.Text = dicedamage.ToString();    

        }
        //Buy Dice Button
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (money > price_dice)
            {
                money = money - price_dice;
                dice++;
                label3.Text = dice.ToString();
                price_dice = 1.7f * price_dice;

                  price_dice = (float)Math.Round(price_dice);                                         
                button2.Text = buydice + space + price_dice + dollarsign;
                if (dice == 15)
                {
                    button2.Enabled = false;
                    button2.Text = disabled;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = money.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(monster_spawned == false)
            {
                
               int monster_spawn = rand.Next(1, 3);
                if(monster_spawn == 3)
                {
                    //spawn monster
                    monster_spawned = !monster_spawned;
                }                
            }
            
        }




        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
