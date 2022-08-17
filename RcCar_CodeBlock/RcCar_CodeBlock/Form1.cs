using System;
using System.Net;
using System.IO;

namespace RcCar_CodeBlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            api api = new api();

            switch (e.KeyCode)
            {
                case Keys.S:
                    api.Set("stop");
                    lb_console.Text = "정지";
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            api api = new api();
            switch (e.KeyChar)
            {
                case 'w' :
                    api.Set("front");
                    lb_console.Text = "전진";
                    break;
                case 'a':
                    api.Set("left");
                    lb_console.Text = "좌회전";
                    break;
                case 's':
                    api.Set("back");
                    lb_console.Text = "후진";
                    break;
                case 'd':
                    api.Set("right");
                    lb_console.Text = "우회전";
                    break;
            }
        }
    }

    public class api
    {
        WebRequest request;
        WebResponse response;
        Stream dataStream;
        StreamReader reader;

        public void Set(String Move)
        {
            request = WebRequest.Create("http://192.168.55.1:5000/"+Move); // 호출할 url
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