using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

class TextBoxSample : Form
{
    Button btn;
    TextBox txt;

    TextBoxSample()
    {
        ClientSize = new Size(300, 100);

        Controls.Add(txt = new TextBox()
        {
            Location = new Point(20, 30),
            Width = 250,
        });

        Controls.Add(btn = new Button()
        {
            Location = new Point(20, 60),
            Text = "OK"
        });

        txt.TextChanged += Txt_TextChanged;

        btn.Click += Btn_OnClick;
    }

    void Txt_TextChanged(object sender, EventArgs e)
    {
        Text = txt.Text;
    }

    void Btn_OnClick(object sender, EventArgs e)
    {
        MessageBox.Show("Args: " + txt.Text);

        /* バッチ実行 */
        Process p = new Process();
        p.StartInfo.FileName = "Called.bat";
        p.StartInfo.Arguments = txt.Text;
        // p.StartInfo.Verb = "RunAs";
        p.Start();

        /* アプリ終了 */
        Application.Exit();
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new TextBoxSample());
    }
}