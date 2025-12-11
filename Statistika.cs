namespace Wordle;

using System.Text.Json;

public class Data
{
    public int DailyGamesPlayed { get; set; }
    public int DailyGamesWon { get; set; }
    public int DailyGamesLost { get; set; }
    public int DailyCurrentStreak { get; set; }
    public int DailyBestStreak { get; set; }
    public List<int> DailyRowNumber { get; set; } = new();

    public int InfiniteGamesPlayed { get; set; }
    public int InfiniteGamesWon { get; set; }
    public int InfiniteGamesLost { get; set; }
    public int InfiniteCurrentStreak { get; set; }
    public int InfiniteBestStreak { get; set; }
    public List<int> InfiniteRowNumber { get; set; } = new();

    public DateTime LastDailyWin { get; set; }
}

public static class Statistika
{
    private const string fajl = "statistika.json";
    private static Data? trenutnaStatistika;

    public static Data Nalozi()
    {
        if (trenutnaStatistika != null)
            return trenutnaStatistika;

        if (!File.Exists(fajl))
        {
            trenutnaStatistika = new Data();
            return trenutnaStatistika;
        }

        try
        {
            string json = File.ReadAllText(fajl);
            trenutnaStatistika = JsonSerializer.Deserialize<Data>(json) ?? new Data();
            return trenutnaStatistika;
        }
        catch
        {
            trenutnaStatistika = new Data();
            return trenutnaStatistika;
        }
    }

    public static void Shrani(Data stats)
    {
        try
        {
            string json = JsonSerializer.Serialize(stats, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(fajl, json);
            trenutnaStatistika = stats;
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Error while saving stats: {exception.Message}", "Error");
        }
    }

    public static void ZapisZmage(bool isDaily, int stPoskusov)
    {
        var stats = Nalozi();

        if (isDaily)
        {
            stats.DailyGamesPlayed++;
            stats.DailyGamesWon++;
            stats.DailyRowNumber.Add(stPoskusov);

            if (stats.LastDailyWin.Date == DateTime.Today.AddDays(-1))
            {
                stats.DailyCurrentStreak++;
            }
            else if (stats.LastDailyWin.Date != DateTime.Today)
            {
                stats.DailyCurrentStreak = 1;
            }

            stats.LastDailyWin = DateTime.Today;

            if (stats.DailyCurrentStreak > stats.DailyBestStreak)
            {
                stats.DailyBestStreak = stats.DailyCurrentStreak;
            }
        }
        else
        {
            stats.InfiniteGamesPlayed++;
            stats.InfiniteGamesWon++;
            stats.InfiniteRowNumber.Add(stPoskusov);
            stats.InfiniteCurrentStreak++;

            if (stats.InfiniteCurrentStreak > stats.InfiniteBestStreak)
            {
                stats.InfiniteBestStreak = stats.InfiniteCurrentStreak;
            }
        }

        Shrani(stats);
    }

    public static void ZapisPoraza(bool isDaily)
    {
        var stats = Nalozi();

        if (isDaily)
        {
            stats.DailyGamesPlayed++;
            stats.DailyGamesLost++;
            stats.DailyCurrentStreak = 0;
        }
        else
        {
            stats.InfiniteGamesPlayed++;
            stats.InfiniteGamesLost++;
            stats.InfiniteCurrentStreak = 0;
        }

        Shrani(stats);
    }

    public static double ProcentZmag(bool isDaily)
    {
        var stats = Nalozi();
        int igrano = isDaily ? stats.DailyGamesPlayed : stats.InfiniteGamesPlayed;
        int zmagano = isDaily ? stats.DailyGamesWon : stats.InfiniteGamesWon;

        if (igrano == 0) return 0;
        return (double)zmagano/igrano*100;
    }

    public static double PovprecnoStPoskusov(bool isDaily)
    {
        var stats = Nalozi();
        var stPoskusov = isDaily ? stats.DailyRowNumber : stats.InfiniteRowNumber;

        if (stPoskusov.Count == 0) return 0;
        return stPoskusov.Average();
    }
}
