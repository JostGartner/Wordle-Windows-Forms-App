namespace Wordle;

public partial class FormStatistika : Form
{
    public FormStatistika()
    {
        InitializeComponent();
    }

    private void FormStatistika_Load(object sender, EventArgs e)
    {
        NaloziStatistiko();
    }

    private void NaloziStatistiko()
    {
        var stats = Statistika.Nalozi();

        // DAILY STATS
        gamesPlayedDaily.Text = stats.DailyGamesPlayed.ToString();
        gamesWonDaily.Text = stats.DailyGamesWon.ToString();
        gamesLostDaily.Text = stats.DailyGamesLost.ToString();
        winPercentageDaily.Text = $"{Statistika.ProcentZmag(true):F1}%";
        solveSpeedDaily.Text = stats.DailyRowNumber.Count > 0
            ? $"{Statistika.PovprecnoStPoskusov(true):F1}"
            : "-";
        currentWinstreakDaily.Text = stats.DailyCurrentStreak.ToString();
        bestWinstreakDaily.Text = stats.DailyBestStreak.ToString();

        // INFINITE STATS
        gamesPlayedInfinite.Text = stats.InfiniteGamesPlayed.ToString();
        gamesWonInfinite.Text = stats.InfiniteGamesWon.ToString();
        gamesLostInfinite.Text = stats.InfiniteGamesLost.ToString();
        winPercentageInfinite.Text = $"{Statistika.ProcentZmag(false):F1}%";
        solveSpeedInfinite.Text = stats.InfiniteRowNumber.Count > 0
            ? $"{Statistika.PovprecnoStPoskusov(false):F1}"
            : "-";
        currentWinstreakInfinite.Text = stats.InfiniteCurrentStreak.ToString();
        bestWinstreakInfinite.Text = stats.InfiniteBestStreak.ToString();
    }

    private bool StatistikaJePrazna(Data stats)
    {
        return stats.DailyGamesPlayed == 0 &&
               stats.InfiniteGamesPlayed == 0;
    }

    private void btnMenu_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        var stats = Statistika.Nalozi();

        if (StatistikaJePrazna(stats))
        {
            MessageBox.Show(
                "Your statistics are already empty.\n\nThere is nothing to reset.",
                "Reset Statistics",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            return;
        }

        var result = MessageBox.Show(
            "Are you sure you want to reset your statistics?\n\nThis cannot be undone.",
            "Reset Statistics",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            var newStats = new Data();
            Statistika.Shrani(newStats);
            NaloziStatistiko();

            MessageBox.Show("Your statistics have been reset.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
