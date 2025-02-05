using System.Text;

namespace Adatbovites;

public partial class AdatbovitesForm : Form
{
    const string PATH = "D:\\PROJECTS\\CSHARP25011701\\NEPESSEG\\ujadat.txt";

    public AdatbovitesForm()
    {
        InitializeComponent();
        btnKilepes.Click += BtnKilepes_Click;
        btnMentes.Click += BtnMentes_Click;
    }

    private void BtnMentes_Click(object? sender, EventArgs e)
    {
        int nepesseg = int.Parse(tbxNepesseg.Text);
        int fvLakossag = int.Parse(tbxFvLakossag.Text);

        if (fvLakossag > nepesseg)
        {
            lblUzenet.ForeColor = Color.Red;
            lblUzenet.Text = "A fõváros lakossága nem lehet több a népességnél!";

            tbxFvLakossag.Text = tbxNepesseg.Text;
        }
        else
        {
            using StreamWriter sw = new(PATH, true, Encoding.UTF8);

            sw.WriteLine($"{tbxOrszag.Text};{tbxTerulet.Text};{tbxNepesseg.Text};{tbxFovaros.Text};{tbxFvLakossag.Text}");


            lblUzenet.ForeColor = Color.Green;
            lblUzenet.Text = "A Mentés sikeres!";
        }
    }

    private void BtnKilepes_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }
}
