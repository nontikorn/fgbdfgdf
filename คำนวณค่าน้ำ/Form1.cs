using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;// การกำหนดค่า i
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123") //เป็นตัวแสดงรหัสผ่าน เข้าสู่ระบบการคำนวณค่าน้ำ
            {
                Form2 f2 = new Form2();//การเข้าสู่ระบบ จาก form1 ไปยัง form 2 เพื่อแสดงผล
                this.Hide();
                f2.Show();
            }
            else
            {
                i++;
                    if (i == 3)
                {
                    MessageBox.Show("ผิด 3 ครั้ง", "!!");//ถ้ารหัสไม่ถูกต้อง 3 ครั้งโปรแกรมจะปิดทันที
                    this.Close();
                }
                    else
                {
                    MessageBox.Show("รหัสผ่านผิด", "!!");//เป็นตัวเตือน ถ้ารหัสผิดพลาด
                    textBox1.SelectAll();
                    textBox1.Clear();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
    }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//การแสดงปุ่มกด Enter
            {
                if (textBox1.Text != "123")//รหัสผ่านเข้าสู่ระบบเพื่อใช้งาน
                {
                    MessageBox.Show("รหัสผ่านคุณผิด", "!");//เป็นตัวเตือนถ้ารหัสผ่านผิดพลาด
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                else textBox2.Focus();
            }
            if (e.KeyCode == Keys.Escape)//การแสดงการเข้าสู่ระบบ
                button1_Click(sender, e);
                
 
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "!!", MessageBoxButtons.OKCancel) == DialogResult.OK)//เป็นการแสดงและแจ้งเตือนว่า (คุณต้องการออกจากโปรแกรมใช่หรือไม่)
                this.Close();

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

