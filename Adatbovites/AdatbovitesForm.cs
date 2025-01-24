namespace Adatbovites;

public partial class AdatbovitesForm : Form
{
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

        }
    }

    private void BtnKilepes_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }
}
