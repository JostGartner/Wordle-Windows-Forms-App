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
        if (LogDaily.AliJeDanesIgral())
        {
            MessageBox.Show(
                "You've already played today's word!\n\n" +
                "Come back tomorrow for a new word.",
                "Daily Wordle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            return;
        }

        this.Hide();
        FormWordle wordleForm = new FormWordle("Daily");
        wordleForm.FormClosed += (s, args) => this.Show();
        wordleForm.Show();
    }

    private void btnStats_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormStatistika statsForm = new FormStatistika();
        statsForm.FormClosed += (s, args) => this.Show();
        statsForm.Show();
    }
}
