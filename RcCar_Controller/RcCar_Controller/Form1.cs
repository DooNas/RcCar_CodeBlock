using System;
using System.Net;
using System.IO;
namespace RcCar_Controller
{
    public partial class Form1 : Form
    {
        public string moving = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_front_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.Add("전진");
            moving = moving + "f";
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.Add("좌회전");
            moving = moving + "l";
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.Add("후진");
            moving = moving + "b";
        }

        private void bt_right_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.Add("우회전");
            moving = moving + "r";
        }

        private void bt_handbreak_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.Add("핸드브레이크");
        }

        private void bt_light_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.Add("비상깜박이");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            lb_CodeBlock.Items.RemoveAt(lb_CodeBlock.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkSet linkSet = new LinkSet();
            linkSet.ShowDialog();
        }

    }

    public class api
    {
        public void Set(String Move)
        {
            WebRequest request;
            WebResponse response;

            Stream dataStream;
            StreamReader reader;
            request = WebRequest.Create(LinkSet.restUrl +"/car?input="+ Move); // 호출할 url
            request.Method = "GET";
            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}