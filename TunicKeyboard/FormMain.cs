namespace TunicKeyboard;

public partial class FormMain : Form
{
    private const int runeWidth = 61;
    private const int spaceWidth = 40;

    private int currPos;
    private Bitmap doubleBuffer;
    private Bitmap previewBuffer;

    private Button? vowelButton;
    private Button? consonantButton;
    private Button? dotButton;

    public FormMain()
    {
        InitializeComponent();
        doubleBuffer = new Bitmap(pictureBoxMain.Size.Width, pictureBoxMain.Size.Height);
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.Clear(Color.White);
        pictureBoxMain.Invalidate();
        previewBuffer = new Bitmap(pictureBoxPreview.Size.Width, pictureBoxPreview.Size.Height);
        using Graphics p = Graphics.FromImage(previewBuffer);
        p.Clear(Color.Transparent);
        pictureBoxPreview.Invalidate();
        currPos = 0;
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
        if (vowelButton != null)
        {
            vowelButton.BackColor = SystemColors.Control;
            vowelButton = null;
        }
        if (consonantButton != null)
        {
            consonantButton.BackColor = SystemColors.Control;
            consonantButton = null;
        }
        if (dotButton != null)
        {
            dotButton.BackColor = SystemColors.Control;
            dotButton = null;
        }
        textBoxMain.Clear();
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.Clear(Color.White);
        pictureBoxMain.Invalidate();
        using Graphics p = Graphics.FromImage(previewBuffer);
        p.Clear(Color.Transparent);
        pictureBoxPreview.Invalidate();
        currPos = 0;
    }

    private void buttonA_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonAR_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonAH_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonAY_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonE_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonEE_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonEER_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonEH_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonERE_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonI_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonIE_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonIR_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonOH_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonOI_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonOO_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonOU_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonOW_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonORE_Click(object sender, EventArgs e)
    {
        SetVowel((Button)sender);
    }

    private void buttonDOT_Click(object sender, EventArgs e)
    {
        SetDot((Button)sender);
    }

    private void buttonB_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonCH_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonD_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonF_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonG_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonH_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonJ_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonK_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonL_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonM_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonN_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonNG_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonP_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonR_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonS_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonSH_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonT_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonTH_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonDTH_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonV_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonW_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonY_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonZ_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void buttonZH_Click(object sender, EventArgs e)
    {
        SetConsonant((Button)sender);
    }

    private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawImage(doubleBuffer, 0, 0);
    }

    private void buttonNEXT_Click(object sender, EventArgs e)
    {
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(previewBuffer, currPos, 0);
        pictureBoxMain.Invalidate();
        currPos += runeWidth;
        if (dotButton == null)
        {
            if (consonantButton != null)
                textBoxMain.AppendText(consonantButton.Text);
            if (vowelButton != null)
                textBoxMain.AppendText(vowelButton.Text);
        }
        else
        {
            if (vowelButton != null)
                textBoxMain.AppendText(vowelButton.Text);
            if (consonantButton != null)
                textBoxMain.AppendText(consonantButton.Text);
        }
        using Graphics p = Graphics.FromImage(previewBuffer);
        p.Clear(Color.Transparent);
        pictureBoxPreview.Invalidate();
        ClearButtons();
    }

    private void buttonSPACE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText(" ");
        currPos += spaceWidth;
    }

    private void SetVowel(Button sender)
    {
        if (vowelButton != null)
        {
            vowelButton.BackColor = SystemColors.Control;
        }
        vowelButton = sender;
        vowelButton.BackColor = Color.LightGreen;
        DrawPreview();
    }

    private void SetConsonant(Button sender)
    {
        if (consonantButton != null)
        {
            consonantButton.BackColor = SystemColors.Control;
        }
        consonantButton = sender;
        consonantButton.BackColor = Color.LightGreen;
        DrawPreview();
    }

    private void SetDot(Button sender)
    {
        if (dotButton != null)
        {
            dotButton = null;
            sender.BackColor = SystemColors.Control;
        }
        else
        {
            dotButton = sender;
            dotButton.BackColor = Color.LightGreen;
        }
        DrawPreview();
    }

    private void DrawPreview()
    {
        using Graphics g = Graphics.FromImage(previewBuffer);
        g.Clear(Color.Transparent);
        if (vowelButton != null)
            g.DrawImage(vowelButton.Image, 0, 0);
        if (consonantButton != null)
            g.DrawImage(consonantButton.Image, 0, 0);
        if (dotButton != null)
            g.DrawImage(dotButton.Image, 0, 0);
        pictureBoxPreview.Invalidate();
    }

    private void pictureBoxPreview_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawImage(previewBuffer, 0, 0);
    }

    private void ClearButtons()
    {
        if (vowelButton != null)
        {
            vowelButton.BackColor = SystemColors.Control;
            vowelButton = null;
        }
        if (consonantButton != null)
        {
            consonantButton.BackColor = SystemColors.Control;
            consonantButton = null;
        }
        if (dotButton != null)
        {
            dotButton.BackColor = SystemColors.Control;
            dotButton = null;
        }
    }
}
