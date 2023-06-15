using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace zad_2
{
    public partial class Form1 :Form
    {
        private Shop shop = new Shop();
        private Playlist playlist = new Playlist();
        public Form1 ()
        {
            InitializeComponent();
        }
       
        private void button2_Click (object sender, EventArgs e)
        {
            shop.WriteAllProducts(listBox1);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            
            string tovar = textBox1.Text;
            decimal price = numericUpDown1.Value;
            int count = (int) numericUpDown2.Value;
            
            if (tovar == "")
            {
                MessageBox.Show("Введите название товара, чтобы добавить", "Ошибка");
                return;
            }
            bool OnlyLetters = true;
            foreach (var ch in tovar)
            {
                if (!char.IsLetter(ch))
                {
                    OnlyLetters = false;
                }
            }
            if (OnlyLetters == false)
            {
                MessageBox.Show("В название товара могут быть только буквы", "Ошибка");
                return;
            }
            else
            {
                Product check = shop.FindByName(tovar);
                if (check == null)
                    shop.CreateProduct(tovar, price, count);
                else
                {
                    MessageBox.Show("Данный товар уже имеется в продаже", "Ошибка");
                }
            }
            
            
        }

        private void button3_Click (object sender, EventArgs e)
        {
            string tovar = textBox1.Text;
            
            if (tovar == "")
            {
                MessageBox.Show("Введите название товара, чтобы купить", "Ошибка");
                return;
            }
            Product toSell = shop.FindByName(tovar);
            if (toSell != null)
            {
                shop.Sell(toSell);
                shop.WriteAllProducts(listBox1);
                
            }
            else
                MessageBox.Show("Данного товара нет", "Ошибка");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Прибыль магазина состовляет {shop.Profit} руб.", "Прибыль");
        }

        //-----------------------Плэйлист------------------------------------
        private void Update()
        {
            try
            {
                Song song = playlist.CurrentSong();
                label6.Text = song.Author;
                label9.Text = song.Title;
                label10.Text = song.Filename;
            }
            catch (IndexOutOfRangeException)
            { 
            }
            
           
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string author = textBox2.Text;
            string title = textBox3.Text;
            string filename = textBox4.Text;
            if (author == "" || title == "" || filename == "")
            {
                MessageBox.Show("Введите все необходимые поля", "Ошибка");
            }
            else
            {
                playlist.Add(author, title, filename);
            }
        }



        private void button14_Click(object sender, EventArgs e)
        {
            string author = textBox2.Text;
            string title = textBox3.Text;
            string filename = textBox4.Text;
            if (author == "" || title == "" || filename == "")
            {
                MessageBox.Show("Введите все необходимые поля", "Ошибка");
            }
            else
            {
                Song song = new Song(author, title, filename);
                playlist.Add(song);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playlist.Next();
            Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playlist.Back();
            Update();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDown3.Value;
            playlist.Search(index);
            Update();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            playlist.Start();
            Update();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            playlist.End();
            Update();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string author = textBox2.Text;
                string title = textBox3.Text;
                string filename = textBox4.Text;
                if (author == "" || title == "" || filename == "")
                {
                    MessageBox.Show("Введите все необходимые поля", "Ошибка");
                }
                else
                {
                    Song song = new Song(author, title, filename);
                    playlist.Remove(song);
                    Update();
                }
            }
            catch (IndexOutOfRangeException)
            { 
            }
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDown3.Value;
            playlist.Remove(index);
            Update();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            label6.Text = "пусто";
            label9.Text = "пусто";
            label10.Text = "пусто";
        }
    }
}
