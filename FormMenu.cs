namespace Wordle;

public partial class FormMenu : Form
{
    public FormMenu()
    {
        InitializeComponent();
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnInfinite_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormWordle wordleForm = new FormWordle("Infinite");
        wordleForm.FormClosed += (s, args) => this.Show();
        wordleForm.Show();
    }

    private void btnNavodila_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormNavodila navodilaForm = new FormNavodila();
        navodilaForm.FormClosed += (s, args) => this.Show();
        navodilaForm.Show();
    }

    private void btnDaily_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormWordle wordleForm = new FormWordle("Daily");
        wordleForm.FormClosed += (s, args) => this.Show();
        wordleForm.Show();
    }
}
