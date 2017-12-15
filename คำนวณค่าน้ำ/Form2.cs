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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double price = 0, i = 0, Service = 0, total = 0, vat = 0, total1 = 0; //เป็นตัวกำหนดตัวแปลต่างๆ

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear(); //เป็นการเคลียร์ข้อมูลของการคำนวณค่าน้ำ ถ้าทำการคำนวณเสร็จแล้ว (กดปุ่ม เคลียร์ แล้วโปรแกรมจะทำการเริ่มใหม่ของของมูลคำนวณค่าน้ำ)
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox3.SelectAll();
            textBox3.Focus();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cash, change; //เป็นการแสดงผลของ (เงินถอน) ใน textBox ที่จะให้แสดงผลค่า (เงินถอน)
            cash = double.Parse(textBox1.Text);
            if (cash >= total)
            {
                change = cash - total; //การกำหนดค่า (จุดทศนิยม)
                textBox2.Text = change.ToString("#,##.00");
            }
            else
            {
                MessageBox.Show("กรุณาใส่จำนวนเงินให้ครบ", "เตือน"); //เป็นการแจ้งเตือน (ถ้าใส่จำนวนเงินไม่ครบ) ในเงินถอน
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "1-30")//เป็นการกำหนดข้อมูลของค่าน้ำที่เราใช้ไป ทั้งปริมาณน้ำและราคาน้ำ
            {
                label4.Text = "8.30";
            }
            else if (comboBox1.SelectedItem == "31-40")
            {
                label4.Text = "10.03";
            }
            else if (comboBox1.SelectedItem == "41-50")
            {
                label4.Text = "10.35";
            }
            else if (comboBox1.SelectedItem == "51-60")
            {
                label4.Text = "10.68";
            }
            else if (comboBox1.SelectedItem == "61-70")
            {
                label4.Text = "11.00";
            }
            else if (comboBox1.SelectedItem == "71-80")
            {
                label4.Text = "11.33";
            }
            else if (comboBox1.SelectedItem == "81-90")
            {
                label4.Text = "12.50";
            }
            else if (comboBox1.SelectedItem == "91-100")
            {
                label4.Text = "12.82";
            }
            else if (comboBox1.SelectedItem == "101-120")
            {
                label4.Text = "13.15";
            }
            else if (comboBox1.SelectedItem == "121-160")
            {
                label4.Text = "13.47";
            }
            else if (comboBox1.SelectedItem == "161-200")
            {
                label4.Text = "13.80";
            }
            else if (comboBox1.SelectedItem == "มากกว่า 200")
            {
                label4.Text = "14.45";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1-30");//เป็นการแสดงผลค่าน้ำและปริมาณน้ำใน form 2
            comboBox1.Items.Add("31-40");
            comboBox1.Items.Add("41-50");
            comboBox1.Items.Add("51-60");
            comboBox1.Items.Add("61-70");
            comboBox1.Items.Add("71-80");
            comboBox1.Items.Add("81-90");
            comboBox1.Items.Add("91-100");
            comboBox1.Items.Add("101-120");
            comboBox1.Items.Add("121-160");
            comboBox1.Items.Add("161-200");
            comboBox1.Items.Add("มากกว่า 200");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = double.Parse(label4.Text);//เป็นการแสดงผล ปริมาณน้ำและค่าน้ำใน textBox ที่เราต้องการให้แสดงเพื่อจะได้รู้ผลลัพธ์ของการใช้น้ำและจำนวนเงินที่ต้องจ่าย
            Service = double.Parse(label9.Text);
            i = price * 10;
            vat = total * 7 / 100;
            total = i + Service;
            total1 = vat + total;
            textBox3.Text = i.ToString("#,##.00");
            textBox4.Text = vat.ToString("#,##.00");
            textBox5.Text = total.ToString("#,##.00");
            textBox6.Text = total1.ToString("#,##.00");

        }
    }
    }

