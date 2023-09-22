using System;
using System.Drawing;
using System.Windows.Forms;

class TextBoxSample : Form
{
    TextBox txt;

    TextBoxSample()
    {
        ClientSize = new Size(300, 100);

        Controls.Add(txt = new TextBox()
        {
            Location = new Point(20, 30),
            Width = 250,
        });

        txt.TextChanged += Txt_TextChanged;
    }

    void Txt_TextChanged(object sender, EventArgs e)
    {
        Text = txt.Text;
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new TextBoxSample());
    }
}