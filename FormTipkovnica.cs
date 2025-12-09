namespace Wordle;

public partial class FormTipkovnica : Form
{
    private FormWordle wordleForm;
    private Dictionary<char, Button> keyButtons = new();

    public FormTipkovnica(FormWordle stars)
    {
        InitializeComponent();
        wordleForm = stars;
        InitializeTipkovnica();
    }

    private void InitializeTipkovnica()
    {
        keyButtons['Q'] = btnQ;
        keyButtons['W'] = btnW;
        keyButtons['E'] = btnE;
        keyButtons['R'] = btnR;
        keyButtons['T'] = btnT;
        keyButtons['Y'] = btnY;
        keyButtons['U'] = btnU;
        keyButtons['I'] = btnI;
        keyButtons['O'] = btnO;
        keyButtons['P'] = btnP;
        keyButtons['A'] = btnA;
        keyButtons['S'] = btnS;
        keyButtons['D'] = btnD;
        keyButtons['F'] = btnF;
        keyButtons['G'] = btnG;
        keyButtons['H'] = btnH;
        keyButtons['J'] = btnJ;
        keyButtons['K'] = btnK;
        keyButtons['L'] = btnL;
        keyButtons['Z'] = btnZ;
        keyButtons['X'] = btnX;
        keyButtons['C'] = btnC;
        keyButtons['V'] = btnV;
        keyButtons['B'] = btnB;
        keyButtons['N'] = btnN;
        keyButtons['M'] = btnM;

        foreach (var key in keyButtons)
        {
            char crka = key.Key;
            Button btn = key.Value;

            btn.Click += (s, e) => wordleForm.DodajCrko(crka);

            btn.BackColor = Color.LightGray;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font(btn.Font.Name, Convert.ToInt32(btn.Height * 0.3333333333333333));
        }

        btnENTER.BackColor = Color.LightGray;
        btnBACKSPACE.BackColor = Color.LightGray;

        btnENTER.Click += (s, e) => wordleForm.UganiEnter();
        btnBACKSPACE.Click += (s, e) => wordleForm.OdstraniCrko();
    }

    public void PosodobiBarve(Dictionary<char, Color> barve)
    {
        Color defaultColor = Color.LightGray;

        foreach (var pobarvan in barve)
        {
            char crka = pobarvan.Key;
            Color novaBarva = pobarvan.Value;

            if (!keyButtons.ContainsKey(crka))
                continue;

            var btn = keyButtons[crka];
            Color trenutnaBarva = btn.BackColor;

            if (trenutnaBarva == Color.FromArgb(0, 192, 0))
                continue;

            if (novaBarva == Color.FromArgb(0, 192, 0))
            {
                btn.BackColor = novaBarva;
            }
            else if (novaBarva == Color.Yellow && trenutnaBarva == defaultColor)
            {
                btn.BackColor = novaBarva;
            }
            else if (novaBarva == Color.Gray && trenutnaBarva == defaultColor)
            {
                btn.BackColor = novaBarva;
            }
        }
    }

    public void ResetirajBarve()
    {
        foreach (var btn in keyButtons.Values)
        {
            btn.BackColor = Color.LightGray;
        }
    }
}
