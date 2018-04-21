using EscapeWall.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeWall
{
    public partial class Form1 : Form
    {
        TextBox Rdl1Answer;
        Form Riddle1;

        public Form1()
        {
            InitializeComponent();
            initRdl1();
            Riddle1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Riddle1.Show();
        }

        private void Rdl1button1_Click(object sender, EventArgs e)
        {
            if (Rdl1Answer.Text == "1234")
            {
                run_cmd();
            }
            else
            {

            }
        }

        private void run_cmd()
        {
            string fileName = @"C:\Users\HarelPc\Documents\Arduino\escapeWall\motor\escapeWall.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\HarelPc\AppData\Local\Programs\Python\Python36-32\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();

        }

        private void initRdl1()
        {
            //
            // Riddle1
            //
            Riddle1 = new Form();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            Riddle1.StartPosition = FormStartPosition.CenterScreen;
            Riddle1.BackgroundImage = ((Image)(resources.GetObject("button1.BackgroundImage")));
            Riddle1.AutoScaleDimensions = new SizeF(8F, 16F);
            Riddle1.AutoScaleMode = AutoScaleMode.Font;
            Riddle1.ClientSize = new Size(1202, 740);


            // 
            // Rdl1TextBox1
            // 
            TextBox Rdl1TextBox1 = new TextBox();
            Rdl1TextBox1.Location = new Point(800, 100);
            Rdl1TextBox1.Multiline = true;
            Rdl1TextBox1.Name = "textBox1";
            Rdl1TextBox1.ScrollBars = ScrollBars.Vertical;
            Rdl1TextBox1.Size = new Size(323, 323);
            Rdl1TextBox1.TabIndex = 13;
            string rdleText = @"עלילה
                               מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל 
                               מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל
                               מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל
                               מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל
                               מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל
                               מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל מלל";
            Rdl1TextBox1.Text = rdleText;
            Rdl1TextBox1.TextAlign = HorizontalAlignment.Right;
            Rdl1TextBox1.ReadOnly = true;

            Riddle1.Controls.Add(Rdl1TextBox1);

            // 
            // Rdl1TextBox2 Question
            // 
            TextBox Rdl1TextBox2 = new TextBox();
            Rdl1TextBox2.Location = new Point(100, 100);
            Rdl1TextBox2.Multiline = true;
            Rdl1TextBox2.Name = "textBox1";
            //Rdl1TextBox2.ScrollBars = ScrollBars.Vertical;
            Rdl1TextBox2.Size = new Size(150, 50);
            Rdl1TextBox2.TabIndex = 13;
            string QText = @"How much is 1235 - 1 ?";
            Rdl1TextBox2.Text = QText;
            Rdl1TextBox2.TextAlign = HorizontalAlignment.Right;
            Rdl1TextBox2.ReadOnly = true;

            Riddle1.Controls.Add(Rdl1TextBox2);


            // 
            // Rdl1Answer
            // 
            Rdl1Answer = new TextBox();
            Rdl1Answer.Location = new Point(100, 200);
            Rdl1Answer.Multiline = true;
            Rdl1Answer.Name = "textBox1";
            Rdl1Answer.Size = new Size(150, 50);
            Rdl1Answer.TabIndex = 13;
            string AText = @"";
            Rdl1Answer.Text = AText;
            Rdl1Answer.TextAlign = HorizontalAlignment.Right;

            Riddle1.Controls.Add(Rdl1Answer);

            //
            // Lable Question
            //
            Label labelQ = new Label();
            labelQ.Text = "שאלה";
            labelQ.Location = new Point(280, 100);
            labelQ.Size = new Size(40, 20);
            Riddle1.Controls.Add(labelQ);

            //
            // Label Answer
            //
            Label labelA = new Label();
            labelA.Text = "הכנס תשובה";
            labelA.Location = new Point(280, 200);
            labelA.Size = new Size(80, 20);
            Riddle1.Controls.Add(labelA);

            // 
            // Rdl1button1 Send Answer
            // 
            Button Rdl1button1 = new Button();
            Rdl1button1.Location = new Point(100, 600);
            Rdl1button1.Text = "שלח תשובה";
            Rdl1button1.Name = "rdl1button1";
            Rdl1button1.Size = new Size(100, 50);
            Rdl1button1.TabIndex = 0;
            Rdl1button1.UseVisualStyleBackColor = true;
            Rdl1button1.Click += new EventHandler(Rdl1button1_Click);

            Riddle1.Controls.Add(Rdl1button1);

            //
            // Close Rdl1
            //
            Button closeRdl1 = new Button();
            closeRdl1.Location = new Point(600, 600);
            closeRdl1.Text = "חזור הביתה";
            closeRdl1.Size = new Size(100, 50);
            closeRdl1.Click += new EventHandler(CloseRdl1_Click);

            Riddle1.Controls.Add(closeRdl1);



            Riddle1.Show();
        }

        private void CloseRdl1_Click(object sender, EventArgs e)
        {
            Riddle1.Hide();
            this.Show();
        }
    }
}
