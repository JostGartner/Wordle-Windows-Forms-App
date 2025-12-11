namespace Wordle;

using Microsoft.Data.Sqlite;

public partial class FormWordle : Form
{
    TextBox[,] wordleGrid = new TextBox[6, 5];
    int trenutnaVrsta = 0;
    private string? pravaBeseda;
    private FormTipkovnica? tipkovnicaForm;
    private bool tipkovnicaVidna = true;
    private const string connectionString = "Data Source=wordle.db";
    private string gameMode = "Wordle";
    private bool isDaily = false;

    public FormWordle(string mode = "Wordle")
    {
        InitializeComponent();
        gameMode = mode;
        isDaily = (mode == "Daily");
    }

    private void FormWordle_Load(object sender, EventArgs e)
    {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        this.Text = gameMode;

        wordleGrid = new TextBox[,]
        {
            { row1cell1, row1cell2, row1cell3, row1cell4, row1cell5 },
            { row2cell1, row2cell2, row2cell3, row2cell4, row2cell5 },
            { row3cell1, row3cell2, row3cell3, row3cell4, row3cell5 },
            { row4cell1, row4cell2, row4cell3, row4cell4, row4cell5 },
            { row5cell1, row5cell2, row5cell3, row5cell4, row5cell5 },
            { row6cell1, row6cell2, row6cell3, row6cell4, row6cell5 }
        };

        for (int row = 0; row < 6; row++)
        {
            for (int cell = 0; cell < 5; cell++)
            {
                var grid = wordleGrid[row, cell];

                grid.Enter += (s, e2) => textUgani.Focus();
                grid.MouseDown += (s, e2) => textUgani.Focus();

                grid.Cursor = Cursors.Arrow;
                grid.BackColor = Color.LightGray;
            }
        }

        btnUgani.BackColor = Color.LightGray;
        btnTipkovnica.BackColor = Color.LightGray;

        using var con = new SqliteConnection(connectionString);
        con.Open();

        if (isDaily)
        {
            // DAILY MODE
            pravaBeseda = GetDaily(con);
        }
        else
        {
            // INFINITE MODE
            using var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT beseda FROM uganljiveBesede ORDER BY RANDOM() LIMIT 1";
            pravaBeseda = ((string)cmd.ExecuteScalar()!).Trim().ToUpper();
        }

        textUgani.Focus();
        tipkovnicaForm = new FormTipkovnica(this);
        PozicionirajTipkovnico();
        tipkovnicaForm.Show(this);
    }

    private string GetDaily(SqliteConnection con)
    {
        DateTime today = DateTime.Today;
        int seed = today.Year * 10000 + today.Month * 100 + today.Day;

        using var cmd = con.CreateCommand();

        cmd.CommandText = @"
            SELECT beseda 
            FROM uganljiveBesede 
            ORDER BY beseda 
            LIMIT 1 
            OFFSET ($seed % (SELECT COUNT(*) FROM uganljiveBesede))";
        cmd.Parameters.AddWithValue("$seed", seed);

        return ((string)cmd.ExecuteScalar()!).Trim().ToUpper();
    }

    private void PozicionirajTipkovnico()
    {
        if (tipkovnicaForm == null) return;

        int x = Left + (Width - tipkovnicaForm.Width) / 2;
        int y;

        if (WindowState == FormWindowState.Maximized)
        {
            int konecGrida = row6cell5.Bottom;
            int spacing = Math.Max(30, (int)(ClientSize.Height * 0.1));

            Point gridTocka = PointToScreen(new Point(0, konecGrida));
            y = gridTocka.Y + spacing;
        }
        else
        {
            int offset = 10;
            y = Bottom - tipkovnicaForm.Height - offset;
        }

        tipkovnicaForm.Location = new Point(x, y);
    }

    public void DodajCrko(char crka)
    {
        if (textUgani.Text.Length < 5)
        {
            textUgani.Text += crka;
        }
    }

    public void OdstraniCrko()
    {
        if (textUgani.Text.Length > 0)
        {
            textUgani.Text = textUgani.Text.Substring(0, textUgani.Text.Length - 1);
        }
    }

    public void UganiEnter()
    {
        btnUgani_Click(this, EventArgs.Empty);
    }

    private void textUgani_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string guess = textUgani.Text.Trim().ToUpper();

            if (guess.Length != 5)
            {
                e.SuppressKeyPress = true;
                labelSporocilo.Text = "NOT ENOUGH LETTERS.";
                return;
            }

            if (!ObstajaBeseda(guess))
            {
                e.SuppressKeyPress = true;
                labelSporocilo.Text = "THIS WORD DOES NOT EXIST.";
                return;
            }

            Ugani(guess);
            e.SuppressKeyPress = true;
        }
    }

    private void Ugani(string guess)
    {
        for (int i = 0; i < 5; i++)
        {
            wordleGrid[trenutnaVrsta, i].Text = guess[i].ToString();
        }

        Pobarvaj(guess);

        if (guess == pravaBeseda)
        {
            int poskus = trenutnaVrsta + 1;

            string poskusi = poskus == 1 ? "1 try" :
                            poskus == 2 ? "2 tries" :
                            $"{poskus} tries";

            labelSporocilo.Text = "WELL DONE!";
            textUgani.Enabled = false;
            btnUgani.Enabled = false;

            Statistika.ZapisZmage(isDaily, poskus);

            if (isDaily)
            {
                var result = MessageBox.Show(
                    $"Congratulations! You guessed today's word in {poskusi}.\n\n" +
                    $"Come back tomorrow for a new word!",
                    "Victory!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LogDaily.OznaciIgrano();
                this.Close();
            }
            else
            {
                var result = MessageBox.Show(
                    $"Congratulations! You guessed the word in {poskusi}.\n\nWould you like to play another game?",
                    "Victory!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    NovaIgra();
                }
                else
                {
                    this.Close();
                }
            }
            return;
        }

        trenutnaVrsta++;

        if (trenutnaVrsta >= 6)
        {
            labelSporocilo.Text = $"GAME OVER.";
            textUgani.Enabled = false;
            btnUgani.Enabled = false;

            Statistika.ZapisPoraza(isDaily);

            if (isDaily)
            {
                var result = MessageBox.Show(
                    $"Game over. Today's word was: {pravaBeseda}\n\n" +
                    $"Come back tomorrow for a new word!",
                    "Game Over",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LogDaily.OznaciIgrano();
                this.Close();
            }
            else
            {
                var result = MessageBox.Show(
                    $"Game over. The correct word was: {pravaBeseda}\n\nWould you like to play another game?",
                    "Game Over",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    NovaIgra();
                }
                else
                {
                    this.Close();
                }
            }
            return;
        }

        textUgani.Text = "";
    }
    private void Pobarvaj(string guess)
    {
        string resitev = pravaBeseda!;

        Dictionary<char, int> crkeCounter = new();

        foreach (char crka in resitev)
        {
            if (!crkeCounter.ContainsKey(crka))
                crkeCounter[crka] = 0;

            crkeCounter[crka]++;
        }

        bool[] zelen = new bool[5];

        for (int i = 0; i < 5; i++)
        {
            if (guess[i] == resitev[i])
            {
                zelen[i] = true;
                crkeCounter[guess[i]]--;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            char crka = guess[i];

            if (zelen[i])
            {
                wordleGrid[trenutnaVrsta, i].BackColor = Color.FromArgb(0, 192, 0);
            }
            else if (crkeCounter.ContainsKey(crka) && crkeCounter[crka] > 0)
            {
                wordleGrid[trenutnaVrsta, i].BackColor = Color.Yellow;
                crkeCounter[crka]--;
            }
            else
            {
                wordleGrid[trenutnaVrsta, i].BackColor = Color.Gray;
            }
        }

        PobarvajTipkovnico(guess);
    }

    public void PobarvajTipkovnico(string guess)
    {
        if (tipkovnicaForm == null) return;

        string resitev = pravaBeseda!;
        Dictionary<char, int> crkeCounter = new();

        foreach (char crka in resitev)
        {
            if (!crkeCounter.ContainsKey(crka))
                crkeCounter[crka] = 0;
            crkeCounter[crka]++;
        }

        bool[] zelen = new bool[5];

        for (int i = 0; i < 5; i++)
        {
            if (guess[i] == resitev[i])
            {
                zelen[i] = true;
                crkeCounter[guess[i]]--;
            }
        }

        Dictionary<char, Color> keyBarve = new();

        for (int i = 0; i < 5; i++)
        {
            char crka = guess[i];

            if (zelen[i])
            {
                keyBarve[crka] = Color.FromArgb(0, 192, 0);
            }
            else if (crkeCounter.ContainsKey(crka) && crkeCounter[crka] > 0)
            {
                if (!keyBarve.ContainsKey(crka))
                    keyBarve[crka] = Color.Yellow;
                crkeCounter[crka]--;
            }
            else
            {
                if (!keyBarve.ContainsKey(crka))
                    keyBarve[crka] = Color.Gray;
            }
        }

        tipkovnicaForm.PosodobiBarve(keyBarve);
    }

    private bool ObstajaBeseda(string guess)
    {
        using var con = new SqliteConnection(connectionString);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT COUNT(*) FROM besede WHERE beseda = $b";
        cmd.Parameters.AddWithValue("$b", guess.ToLower());

        return (long)cmd.ExecuteScalar()! > 0;
    }

    private void NovaIgra()
    {
        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                wordleGrid[row, col].Text = "";
                wordleGrid[row, col].BackColor = Color.LightGray;
            }
        }

        trenutnaVrsta = 0;
        textUgani.Enabled = true;
        btnUgani.Enabled = true;
        textUgani.Text = "";
        labelSporocilo.Text = "";
        tipkovnicaForm?.ResetirajBarve();

        using var con = new SqliteConnection(connectionString);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT beseda FROM uganljiveBesede ORDER BY RANDOM() LIMIT 1";
        pravaBeseda = ((string)cmd.ExecuteScalar()!).Trim().ToUpper();

        textUgani.Focus();
    }

    private void btnUgani_Click(object sender, EventArgs e)
    {
        string guess = textUgani.Text.Trim().ToUpper();

        if (guess.Length != 5)
        {
            labelSporocilo.Text = "NOT ENOUGH LETTERS.";
            textUgani.Focus();
            return;
        }

        if (!ObstajaBeseda(guess))
        {
            labelSporocilo.Text = "THIS WORD DOES NOT EXIST.";
            textUgani.Focus();
            return;
        }

        Ugani(guess);
    }

    private void textUgani_TextChanged(object sender, EventArgs e)
    {
        labelSporocilo.Text = "";
    }

    private void textUgani_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar))
            return;

        if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            return;

        e.Handled = true;
    }

    private void FormWordle_LocationChanged(object sender, EventArgs e)
    {
        PozicionirajTipkovnico();
    }

    private void FormWordle_Resize(object sender, EventArgs e)
    {
        PozicionirajTipkovnico();
    }

    private void FormWordle_FormClosing(object sender, FormClosingEventArgs e)
    {
        tipkovnicaForm?.Close();
    }

    private void btnTipkovnica_Click(object sender, EventArgs e)
    {
        if (tipkovnicaForm == null) return;

        if (tipkovnicaVidna)
        {
            tipkovnicaForm.Hide();
            tipkovnicaVidna = false;
            textUgani.Focus();
        }
        else
        {
            tipkovnicaForm.Show(this);
            PozicionirajTipkovnico();
            tipkovnicaVidna = true;
            textUgani.Focus();
        }
    }
}

public class LogDaily
{
    private const string progressFile = "daily_log.txt";

    public static bool AliJeDanesIgral()
    {
        if (!File.Exists(progressFile))
            return false;

        string lastPlayed = File.ReadAllText(progressFile);
        return lastPlayed == DateTime.Today.ToString("yyyy-MM-dd");
    }

    public static void OznaciIgrano()
    {
        File.WriteAllText(progressFile, DateTime.Today.ToString("yyyy-MM-dd"));
    }
}