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
            lblUzenet.Text = "A f�v�ros lakoss�ga nem lehet t�bb a n�pess�gn�l!";

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
