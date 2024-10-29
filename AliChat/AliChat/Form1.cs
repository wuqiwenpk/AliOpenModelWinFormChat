using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labTip.Hide();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            Ask();

        }

        private async void Ask()
        {
            labTip.Show();
            if (textAsk.Text == "请输入提问内容...")
            {
                MessageBox.Show("请输入你想要问的问题！");
                textAsk.Text = "";
                textAsk.Focus();
            }
            textAsk.Text = textAsk.Text.TrimEnd('\n');

            // 调用API
            var result = await AliAPI.Ask(textAsk.Text);
            try
            {
                // 返回结果反序列化
                AliApiResultModel resultModel = JsonSerializer.Deserialize<AliApiResultModel>(result);
                textRes.Text = resultModel.Choices[0].Message.Content;
            }
            catch (Exception)
            {
                textRes.Text = result;
            }
            labTip.Hide();
        }


        private void textAsk_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 检查是否按下了回车键  
            if (e.KeyChar == (char)Keys.Return)
            {
                Ask();
            }
        }

        private void textAsk_Click(object sender, EventArgs e)
        {
            if (textAsk.Text == "请输入提问内容...")
            {
                textAsk.Text = "";
            }
        }
    }
}
