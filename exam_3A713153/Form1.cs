using exam_3A713153.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_3A713153
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();

        int a,b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("比大小換圖片", "開始囉!", MessageBoxButtons.OK);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._005);
            list.Add(Resources._006);
            list.Add(Resources._007);
            list.Add(Resources._008);
            list.Add(Resources._009);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {

                //提取輸入內容
                string input_str = tbInput.Text;
                //轉換int 
                int input_int = int.Parse(input_str);

                //TODO: 寫判斷邏輯
                if (input_int < 40)
                {
                    int index = (new Random()).Next(7);//模擬隨機產生 一個值;
                    
                    pic1.Image = list[index];
                    MessageBox.Show($"{input_int}~?? 還要再大點", "NoNoNo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a = a + 1;
                }
                else if (input_int > 40)
                {
                    int index = (new Random()).Next(3);//模擬隨機產生 一個值;

                    pic1.Image = list[index];
                    MessageBox.Show($"??~{input_int} 在小一點", "NoNoNo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a = a + 1;
                }
                else if (input_int == 40)
                {
                    int index = 7;

                    pic1.Image = list[index];
                    //顯示內容
                    MessageBox.Show($"沒錯!就是{input_int}", "YesYesYes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    a = a + 1;
                }
                rtbout.Text=$"你猜的次數為{a}次";
            }
            catch (Exception)
            {
                //錯誤提示
                int index = 3 ;

                pic1.Image = list[index];
                MessageBox.Show($"怎麼連數字都不想打阿", "我問號", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("關起來","爛遊戲別玩了");
        }

        private void rtbout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
