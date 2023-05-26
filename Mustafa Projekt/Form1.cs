namespace Mustafa_Projekt
{
    public partial class Form1 : Form
    {
        // dem hära är mina variablerna till Datornstal och antal gissningar jag gör.
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            // det läggs till i listruttan så du kan välja något av talen  10 eller 20
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            // denna koden markerar första talet  i listrutan
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            // första koden neråt skapar datorns tal genom att hämta den största talet
            // andra koden under översätter den till heltal och skapar ett (1)
            // det beror på talet du väljer från listrutan antigen 10 eller 20 alltså när du väljer 10----
            //---- ska dator välja tall mellan 1 till 10 eller om du väljer 20 så ska den slumpa ut talet mellan 1 till 20 
            string StörstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(StörstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            // första kodet neråt ska aktiver själva spelet 
            // andra koden aktiverar grupprutan (gbxSpelet)
            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";

            // den hära koden sätter antal gissningar till 0, Från början.
            antalGissningar = 0;

        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissaTal = int.Parse(gissa);

            if (gissaTal == datornsTal)

            {
                lblResultat.Text = "Korrekt efter" +
                antalGissningar + " försök.";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true ;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " försök\n");

            }

            else if (gissaTal < datornsTal)
            {
                lblResultat.Text = "för lågt. försök igen.";

            }
            else
            {
                lblResultat.Text = "för högt. försök igen.";
            }




        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            string StörstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(StörstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);


            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";

            antalGissningar = 0;
        }
    }
}