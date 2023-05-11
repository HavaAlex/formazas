using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formazas
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Szöveg";
            numericUpDown1.Value = 10;
            label1.BackColor = Color.FromArgb(255, 255, 255);
            label1.Size = new Size(100,50);
            radioButton1.Checked = true;
            label1.Text = "Próba";
            radioButton2.Font = new Font("Times New Roman", radioButton2.Font.Size);
            radioButton3.Font = new Font("Comic Sans MS", radioButton3.Font.Size);
            checkBox4.Font = new Font(checkBox4.Font, checkBox4.Font.Style | FontStyle.Bold);
            checkBox5.Font = new Font(checkBox5.Font, checkBox5.Font.Style | FontStyle.Underline);
            checkBox6.Font = new Font(checkBox6.Font, checkBox6.Font.Style | FontStyle.Italic);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Színezés 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (label1.BackColor == Color.FromArgb(255, 255, 255))
            {
                label1.BackColor = Color.FromArgb(0, 0, 0);
            }
            */
            if (checkBox1.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.ForeColor = Color.FromArgb(255, label1.ForeColor.G, label1.ForeColor.B);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.BackColor = Color.FromArgb(255, label1.BackColor.G, label1.BackColor.B);
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.ForeColor = Color.FromArgb(0, label1.ForeColor.G, label1.ForeColor.B);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.BackColor = Color.FromArgb(0, label1.BackColor.G, label1.BackColor.B);
                }
            }

            
                
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            
            if (checkBox2.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.ForeColor = Color.FromArgb(label1.ForeColor.R, label1.ForeColor.G, 255);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.BackColor = Color.FromArgb(label1.BackColor.R, label1.BackColor.G, 255);
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.ForeColor = Color.FromArgb(label1.ForeColor.R, label1.ForeColor.G, 0);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.BackColor = Color.FromArgb(label1.BackColor.R, label1.BackColor.G, 0);
                }
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox3.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.ForeColor = Color.FromArgb(label1.ForeColor.R, 255, label1.ForeColor.B);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.BackColor = Color.FromArgb(label1.BackColor.R, 255, label1.BackColor.B);
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.ForeColor = Color.FromArgb(label1.ForeColor.R, 0, label1.ForeColor.B);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.BackColor = Color.FromArgb(label1.BackColor.R, 0, label1.BackColor.B);
                }
            }
        }
        // Dőlt, aláhúzott, félkövér
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);
            }
            else
            {
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Italic);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);
            }
            else
            {
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Underline);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
            }
            else
            {
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Bold);
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                numericUpDown1.Enabled = true;

                if (checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked == true)
                {
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked == true)
                {
                    checkBox3.Checked = false;
                }

                if (checkBox1.Checked == false)
                {
                    checkBox1.Checked = true;
                }
                if (checkBox2.Checked == false)
                {
                    checkBox2.Checked = true;
                }
                if (checkBox3.Checked == false)
                {
                    checkBox3.Checked = true;
                }

            }
            else if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true; 
                numericUpDown1.Enabled = true;

               

            }
        }
        //Mérettekerés
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 1)
            {
                label1.Size = new Size(Convert.ToInt32(numericUpDown1.Value) * 5, Convert.ToInt32(numericUpDown1.Value) * 2);
                numericUpDown1.Maximum = 56;
                numericUpDown1.Minimum = 10;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                numericUpDown1.Maximum = 80;
                numericUpDown1.Minimum = 10;
                label1.Font = ChangeFontSize(label1.Font, Convert.ToInt32(numericUpDown1.Value));
            }
        }

        //netről lopva
        static public Font ChangeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize,
                        font.Style, font.Unit,
                        font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            return font;
        }

        //Átírás
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

            csere(this);
        }
        public void csere(Form ez)
        {
            if (textBox1.Text == "taiwan")
            {
                ez.BackgroundImage = Properties.Resources.kina;
            }
        }
        

        //Betűtípus
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", label1.Font.Size);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", label1.Font.Size);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", label1.Font.Size);
        }
    }
}
