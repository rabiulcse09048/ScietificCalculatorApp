using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scientific_calculator_own
{
    public partial class frmScientificCalculator : Form
    {
        public frmScientificCalculator()
        {
            InitializeComponent();
        }

        int sign_bit = 0;
        int AddBit = 0;
        int SubBit = 0;
        int MulBit = 0;
        int DivBit = 0;
        int ModBit = 0;
        Boolean f1 = false;
        double currentValue = 0;
        double totalValue = 0;
        string s, x;

        private void btb_1_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(1);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(1);
                sign_bit = 0;
 
            }
            f1 = true;
        }


        private void btn_2_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(2);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(2);
                sign_bit = 0;
            }
            f1 = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(3);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(3);
                sign_bit = 0;
            }
            f1 = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(4);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(4);
                sign_bit = 0;
            }
            f1 = true;


        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(5);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(5);
                sign_bit = 0;
            }
            f1 = true;

        }

        private void btn_6_Click(object sender, EventArgs e)
        {

            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(6);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(6);
                sign_bit = 0;
            }
            f1 = true;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(7);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(7);
                sign_bit = 0;
            }
            f1 = true;
        }


        private void btn_8_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(8);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(8);
                sign_bit = 0;
            }
            f1 = true;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(9);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(9);
                sign_bit = 0;
            }
            f1 = true;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (sign_bit == 0)
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + Convert.ToString(0);

            }

            else
            {
                txtBoxAnswer.Text = Convert.ToString(0);
                sign_bit = 0;
            }
            f1 = true;
        }




        private void reset_signBit()
        {
            AddBit = 0;
            SubBit = 0;
            MulBit = 0;
            DivBit = 0;
            f1 = false;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text.Length != 0)
            {
                calculate();
                reset_signBit();
                AddBit = 1;
                sign_bit = 1;
            }

        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text.Length != 0)
            {
                calculate();
                reset_signBit();
                SubBit = 1;
                sign_bit = 1;
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text.Length != 0)
            {
                calculate();
                reset_signBit();
                MulBit = 1;
                sign_bit = 1;
            }

        }


        private void btn_Division_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text.Length != 0)
            {
                calculate();
                reset_signBit();
                DivBit = 1;
                sign_bit = 1;
            }

        }


        private void calculate()
        {
            try
            {
                if (txtBoxAnswer.Text != ".")
                {
                    currentValue = Convert.ToDouble(txtBoxAnswer.Text);

                    if (f1 == false)
                    {
                        totalValue = currentValue;
                    }

                    else if (AddBit == 1)
                    {
                        totalValue = totalValue + currentValue;
                    }

                    else if (SubBit == 1)
                    {
                        totalValue = totalValue - currentValue;
                    }

                    else if (MulBit == 1)
                    {
                        totalValue = totalValue * currentValue;
                    }

                    else if (DivBit == 1)
                    {
                        totalValue = totalValue / currentValue;
                    }

                    else if (ModBit == 1)
                    {
                        totalValue = totalValue % currentValue;
                    }

                    else
                    {
                        totalValue = currentValue;
                    }

                    txtBoxAnswer.Text = Convert.ToString(totalValue);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text.Length != 0)
            {
                calculate();
                reset_signBit();
            }
            sign_bit = 1;
        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
           
        }

        private void btb_1_by_x_Click(object sender, EventArgs e)
        {
            txtBoxAnswer.Text = Convert.ToString(1 / Convert.ToDouble(txtBoxAnswer.Text));
            sign_bit = 1;
            
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            double s,temp;
            temp = Convert.ToDouble(txtBoxAnswer.Text);
            s = Math.Sqrt(temp);
            txtBoxAnswer.Text = Convert.ToString(s);
            sign_bit = 1;

        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            txtBoxAnswer.Clear();
            sign_bit = 0;
            currentValue = 0;
            totalValue = 0;
            reset_signBit();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            s = txtBoxAnswer.Text;
            int l = s.Length;

            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            txtBoxAnswer.Text = x;
            x = "";
            
        }

        private void btb_x_factorial_Click(object sender, EventArgs e)
        {
            try
            {
                long factorial = 1;
                for (int i = 1; i < (Convert.ToInt32(txtBoxAnswer.Text)); i++)
                {
                    factorial = factorial * i;
                }
                txtBoxAnswer.Text = Convert.ToString(factorial);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Sin(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Cos(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Tan(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sin_Inverse_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Asin(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cos_Inverse_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Acos(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tan_Inverse_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Atan(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sinh_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Sinh(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cosh_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Cosh(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntanh_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Tanh(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PI_Click(object sender, EventArgs e)
        {
            txtBoxAnswer.Text = Convert.ToString(Math.PI);
            sign_bit = 1;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text.Length != 0)
            {
                calculate();
                reset_signBit();
                ModBit = 1;
                sign_bit = 1;
            }
        }

        private void btn_e_power_x_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Exp(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Log(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlog10_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Log10(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Round_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Round(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Floor_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Floor(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Trunc_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Truncate(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Ceil_Click(object sender, EventArgs e)
        {
            try
            {
                double l, s;
                l = Convert.ToDouble(txtBoxAnswer.Text);
                s = Math.Ceiling(l);
                txtBoxAnswer.Text = Convert.ToString(s);
                sign_bit = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

      

      
    }
}
