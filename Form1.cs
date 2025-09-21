using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[] TotalPriceArr = { 0, 0, 0, 0 };
        float[] ToppingArr = { 0, 0, 0, 0, 0, 0 };
        string[] ToppingNameList = { "", "", "", "", "", "" };

        private float CalcTotalPrice(float[] arr)
        {
            float totalprice = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalprice += arr[i];
            }

            return totalprice;
        }

        private void ConnectToppingList()
        {
            ToppingsList.Text = "";
            for(int i =0;i<ToppingNameList.Length;i++)
            {
                ToppingsList.Text += ToppingNameList[i];

                if (ToppingNameList[i] != "")
                    ToppingsList.Text += ",";

            }

            if (ToppingsList.Text == "")
                ToppingsList.Text = "No Toppings";
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            PizzaSize.Text = rbSmall.Text;
            TotalPriceArr[0] = 30;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            PizzaSize.Text = rbMedium.Text;
            TotalPriceArr[0] = 35;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            PizzaSize.Text = rbLarge.Text;
            TotalPriceArr[0] = 40;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            CrustType.Text = rbThin.Text;
            TotalPriceArr[1] = 15;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            CrustType.Text = rbThink.Text;
            TotalPriceArr[1] = 20;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if(chkExtraCheese.Checked == true)
            {
                ToppingNameList[0] = chkExtraCheese.Text;
                ToppingArr[0] = 5;
            }

            ConnectToppingList();
            TotalPriceArr[2] = CalcTotalPrice(ToppingArr);
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
            {
                ToppingNameList[1] = chkMushrooms.Text;
                ToppingArr[1] = 5;
            }

            ConnectToppingList();
            TotalPriceArr[2] = CalcTotalPrice(ToppingArr);
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
            {
                ToppingNameList[2] = chkTomatos.Text;
                ToppingArr[2] = 5;
            }

            ConnectToppingList();
            TotalPriceArr[2] = CalcTotalPrice(ToppingArr);
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
            {
                ToppingNameList[3] = chkOnion.Text;
                ToppingArr[3] = 5;
            }

            ConnectToppingList();
            TotalPriceArr[2] = CalcTotalPrice(ToppingArr);
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
            {
                ToppingNameList[4] = chkOlives.Text;
                ToppingArr[4] = 5;
            }

            ConnectToppingList();
            TotalPriceArr[2] = CalcTotalPrice(ToppingArr);
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
            {
                ToppingNameList[5] = chkGreenPeppers.Text;
                ToppingArr[5] = 5;
            }

            ConnectToppingList();
            TotalPriceArr[2] = CalcTotalPrice(ToppingArr);
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            WherToEat.Text = rbEatIn.Text;
            TotalPriceArr[3] = 20;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            WherToEat.Text = rbTakeOut.Text;
            TotalPriceArr[3] = 10;
            TotalPrice.Text = "$" + CalcTotalPrice(TotalPriceArr).ToString();
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure ?", "Confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Has Been Done.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                btOrderPizza.Enabled = false;
            }
        }

        private void reset_radoibutton_checkbox()
        {
            rbMedium.Checked = true;
            rbThin.Checked= true;
            rbEatIn.Checked = true;
            rbSmall.Checked = false;
            rbLarge.Checked = false;
            rbThink.Checked = false;
            rbTakeOut.Checked = false;
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatos.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;
        }

        private void reset_labelstext()
        {
            PizzaSize.Text = "Medium";
            CrustType.Text = "Thin Crust";
            ToppingsList.Text = "No Toppings";
            WherToEat.Text = "Eat In";
            TotalPrice.Text = "$70";
        }

        private void resetTotalPriceArr()
        {
            TotalPriceArr[0] = 0;
            TotalPriceArr[1] = 0;
            TotalPriceArr[2] = 0;
            TotalPriceArr[3] = 0;
        }

        private void resetToppingArr()
        {
            ToppingArr[0] = 0;
            ToppingArr[1] = 0;
            ToppingArr[2] = 0;
            ToppingArr[3] = 0;
            ToppingArr[4] = 0;
            ToppingArr[5] = 0;
        }

        private void resetToppingNameList()
        {
            ToppingNameList[0] = "";
            ToppingNameList[1] = "";
            ToppingNameList[2] = "";
            ToppingNameList[3] = "";
            ToppingNameList[4] = "";
            ToppingNameList[5] = "";
        }

        private void reset_AllArrays()
        {
            resetTotalPriceArr();
            resetToppingArr();
            resetToppingNameList();
        }

        private void resetgroupboxes()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            btOrderPizza.Enabled = true;
        }
        private void btResetForm_Click(object sender, EventArgs e)
        {
            resetgroupboxes();
            reset_radoibutton_checkbox();
            reset_labelstext();
            reset_AllArrays();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetgroupboxes();
            reset_radoibutton_checkbox();
            reset_labelstext();
            reset_AllArrays();
        }
    }
}
