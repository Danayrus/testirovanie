using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testirovanie_treugl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            if (f_side.Text != "" && s_side.Text != "" && t_side.Text != "")
            {
                int first_side = Convert.ToInt32(f_side.Text),
                    second_side = Convert.ToInt32(s_side.Text),
                    third_side = Convert.ToInt32(t_side.Text);

                if (first_side + second_side > third_side && first_side + third_side > second_side &&
                    second_side + third_side > first_side)
                {

                    if (first_side == second_side && first_side == third_side
                        && second_side == third_side)
                    {
                        l_text.Text = "Полученный треугольник равносторонний";
                    }
                    else if (first_side == second_side || first_side == third_side ||
                        second_side == third_side)
                    {
                        l_text.Text = "Полученный треугольник равнобедренный";
                    }
                    else
                    {
                        l_text.Text = "Полученный треугольник разносторонний";
                    }
                }
                else
                {
                    MessageBox.Show("Такой треугольник не существует!", "Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные в поля!", "Ошибка!");

            }

        }

        private void f_side_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                

            }
            if (e.KeyChar == 8)
            {
                return;
            }
            e.Handled = true;
            MessageBox.Show("Данные символы нельзя вносить в поля!", "Ошибка!");
        }
    }
}
