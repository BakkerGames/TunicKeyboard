namespace TunicKeyboard;

public partial class FormMain : Form
{
    private const int runeWidth = 61;
    private const int spaceWidth = 40;

    private int currPos;
    private Bitmap doubleBuffer = new(1186, 162);

    public FormMain()
    {
        InitializeComponent();
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.Clear(Color.White);
        currPos = 0;
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
        textBoxMain.Clear();
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.Clear(Color.White);
        pictureBoxMain.Invalidate();
        currPos = 0;
    }

    private void buttonA_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("A");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonAR_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("AR");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonAH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("AH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonAY_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("AY");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("E");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonEE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("EE");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonEER_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("EER");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonEH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("EH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonERE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("ERE");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonI_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("I");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonIE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("IE");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonIR_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("IR");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonOH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("OH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonOI_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("OI");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonOO_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("OO");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonOU_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("OU");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonOW_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("OW");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonORE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("ORE");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonDOT_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText(".");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonB_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("B");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonCH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("CH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonD_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("D");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonF_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("F");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonG_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("G");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("H");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonJ_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("J");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonK_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("K");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonL_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("L");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonM_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("M");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonN_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("N");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonNG_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("NG");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonP_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("P");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonR_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("R");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonS_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("S");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonSH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("SH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonT_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("T");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonTH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("TH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonDTH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("DTH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonV_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("V");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonW_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("W");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonY_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("Y");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonZ_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("Z");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void buttonZH_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText("ZH");
        using Graphics g = Graphics.FromImage(doubleBuffer);
        g.DrawImage(((Button)sender).Image, currPos, 0);
        pictureBoxMain.Invalidate();
    }

    private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawImage(doubleBuffer, 0, 0);
    }

    private void buttonNEXT_Click(object sender, EventArgs e)
    {
        currPos += runeWidth;
    }

    private void buttonSPACE_Click(object sender, EventArgs e)
    {
        textBoxMain.AppendText(" ");
        currPos += spaceWidth + runeWidth;
    }
}
