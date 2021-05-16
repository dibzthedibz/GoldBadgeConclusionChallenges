using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaimsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form form1 = new Form();
            Button f1Button = new Button();

            Form form2 = new Form();
            Button f2Button1 = new Button();
            Button f2Button2 = new Button();
            Button f2Button3 = new Button();
            Button f2Button4 = new Button();

            Form form3 = new Form();
            Button f3Button1 = new Button();
            Button f3Button2 = new Button();

            Form form4 = new Form();
            Button f4Button1 = new Button();
            Button f4Button2 = new Button();

            Form form5 = new Form();
            Button f5Button1 = new Button();
            Button f5Button2 = new Button();

            //Setting the properties for my Forms and Controls.
            //{

            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Size = new System.Drawing.Size(500, 250);
            form1.Text = "Claims Department Version 1.00";
            form1.HelpButton = true;
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.MaximizeBox = false;
            form1.MinimizeBox = false;
            form1.BackColor = Color.DarkBlue;

            f1Button.BackColor = Color.LightBlue;
            f1Button.Size = new Size(300, 50);
            f1Button.Text = "Open Claims Menu";
            f1Button.Location = new Point(95, 90);
            f1Button.DialogResult = DialogResult.OK;
            form1.Controls.Add(f1Button);
            form1.ShowDialog();

            //This right here took me two hours.
            f1Button.Click += new EventHandler(fButton1_Click);

            void fButton1_Click(object sender, EventArgs e)
            {
                form1.Dispose();
                form2.ShowDialog();
            }

            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Size = new System.Drawing.Size(500, 450);
            form2.Text = "Claims Department Version 1.00";
            form2.HelpButton = true;
            form2.FormBorderStyle = FormBorderStyle.FixedDialog;
            form2.MaximizeBox = false;
            form2.MinimizeBox = false;
            form2.BackColor = Color.DarkBlue;

            f2Button1.BackColor = Color.LightBlue;
            f2Button1.Size = new Size(300, 50);
            f2Button1.Text = "See All Current Claims";
            f2Button1.Location = new Point(95, 45);
            f2Button1.DialogResult = DialogResult.OK;

            f2Button2.BackColor = Color.LightBlue;
            f2Button2.Size = new Size(300, 50);
            f2Button2.Text = "Take Care Of Next Claim";
            f2Button2.Location = new Point(f2Button1.Left, f2Button1.Height + f2Button1.Top + 10);
            f2Button2.DialogResult = DialogResult.OK;

            f2Button3.BackColor = Color.LightBlue;
            f2Button3.Size = new Size(300, 50);
            f2Button3.Text = "Enter New Claim";
            f2Button3.Location = new Point(f2Button2.Left, f2Button2.Height + f2Button2.Top + 10);
            f2Button3.DialogResult = DialogResult.OK;

            f2Button4.BackColor = Color.LightBlue;
            f2Button4.Size = new Size(300, 50);
            f2Button4.Text = "Exit Program";
            f2Button4.Location = new Point(f2Button3.Left, f2Button3.Height + f2Button3.Top + 10);
            f2Button4.DialogResult = DialogResult.OK;

            form2.Controls.Add(f2Button1);
            form2.Controls.Add(f2Button2);
            form2.Controls.Add(f2Button3);
            form2.Controls.Add(f2Button4);
            form2.ShowDialog();

            f2Button1.Click += new EventHandler(f2Button1_Click);

            void f2Button1_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form3.ShowDialog();
            }

            f2Button2.Click += new EventHandler(f2Button2_Click);

            void f2Button2_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form4.ShowDialog();
            }

            f2Button3.Click += new EventHandler(f2Button3_Click);

            void f2Button3_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form5.ShowDialog();
            }

            f2Button4.Click += new EventHandler(f2Button4_Click);

            void f2Button4_Click(object sender, EventArgs e)
            {
                form2.Dispose();
            }

            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.Size = new System.Drawing.Size(500, 250);
            form3.Text = "Claims Department Version 1.00";
            form3.HelpButton = true;
            form3.FormBorderStyle = FormBorderStyle.FixedDialog;
            form3.MaximizeBox = false;
            form3.MinimizeBox = false;
            form3.BackColor = Color.DarkBlue;

            f3Button1.BackColor = Color.LightBlue;
            f3Button1.Size = new Size(300, 50);
            f3Button1.Text = "Open Claims Menu";
            f3Button1.Location = new Point(95, 90);
            f3Button1.DialogResult = DialogResult.OK;

            f3Button2.BackColor = Color.LightBlue;
            f3Button2.Size = new Size(300, 50);
            f3Button2.Text = "Open Claims Menu";
            f3Button2.Location = new Point(95, 90);
            f3Button2.DialogResult = DialogResult.OK;

            form3.Controls.Add(f3Button1);
            form3.Controls.Add(f3Button2);
            form3.ShowDialog();

            f3Button1.Click += new EventHandler(f3Button1_Click);

            void f3Button1_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form3.ShowDialog();
            }

            f3Button2.Click += new EventHandler(f3Button2_Click);

            void f3Button2_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form1.ShowDialog();
            }

            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.Size = new System.Drawing.Size(500, 250);
            form4.Text = "Claims Department Version 1.00";
            form4.HelpButton = true;
            form4.FormBorderStyle = FormBorderStyle.FixedDialog;
            form4.MaximizeBox = false;
            form4.MinimizeBox = false;
            form4.BackColor = Color.DarkBlue;

            f4Button1.BackColor = Color.LightBlue;
            f4Button1.Size = new Size(300, 50);
            f4Button1.Text = "Open Claims Menu";
            f4Button1.Location = new Point(95, 90);
            f4Button1.DialogResult = DialogResult.OK;

            f4Button2.BackColor = Color.LightBlue;
            f4Button2.Size = new Size(300, 50);
            f4Button2.Text = "Open Claims Menu";
            f4Button2.Location = new Point(95, 90);
            f4Button2.DialogResult = DialogResult.OK;

            form4.Controls.Add(f4Button1);
            form4.Controls.Add(f4Button2);
            form4.ShowDialog();

            f4Button1.Click += new EventHandler(f4Button1_Click);

            void f4Button1_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form3.ShowDialog();
            }

            f4Button2.Click += new EventHandler(f4Button2_Click);

            void f4Button2_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form1.ShowDialog();
            }

            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.Size = new System.Drawing.Size(500, 250);
            form5.Text = "Claims Department Version 1.00";
            form5.HelpButton = true;
            form5.FormBorderStyle = FormBorderStyle.FixedDialog;
            form5.MaximizeBox = false;
            form5.MinimizeBox = false;
            form5.BackColor = Color.DarkBlue;

            f5Button1.BackColor = Color.LightBlue;
            f5Button1.Size = new Size(300, 50);
            f5Button1.Text = "Open Claims Menu";
            f5Button1.Location = new Point(95, 90);
            f5Button1.DialogResult = DialogResult.OK;

            f5Button2.BackColor = Color.LightBlue;
            f5Button2.Size = new Size(300, 50);
            f5Button2.Text = "Open Claims Menu";
            f5Button2.Location = new Point(95, 90);
            f5Button2.DialogResult = DialogResult.OK;

            form5.Controls.Add(f5Button1);
            form5.Controls.Add(f5Button2);
            form5.ShowDialog();

            f5Button1.Click += new EventHandler(f5Button1_Click);

            void f5Button1_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form3.ShowDialog();
            }

            f5Button2.Click += new EventHandler(f5Button2_Click);

            void f5Button2_Click(object sender, EventArgs e)
            {
                form2.Dispose();
                form4.ShowDialog();
            }
        }
    }
}
