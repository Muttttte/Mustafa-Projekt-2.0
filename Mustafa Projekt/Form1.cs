namespace Mustafa_Projekt
{
    public partial class Form1 : Form
    {
        // dem h�ra �r mina variablerna till Datornstal och antal gissningar jag g�r.
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            // det l�ggs till i listruttan s� du kan v�lja n�got av talen  10 eller 20
            lbxSt�rstaTalet.Items.Add(10);
            lbxSt�rstaTalet.Items.Add(20);
            // denna koden markerar f�rsta talet  i listrutan
            lbxSt�rstaTalet.SelectedItem = lbxSt�rstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            // f�rsta koden ner�t skapar datorns tal genom att h�mta den st�rsta talet
            // andra koden under �vers�tter den till heltal och skapar ett (1)
            // det beror p� talet du v�ljer fr�n listrutan antigen 10 eller 20 allts� n�r du v�ljer 10----
            //---- ska dator v�lja tall mellan 1 till 10 eller om du v�ljer 20 s� ska den slumpa ut talet mellan 1 till 20 
            string St�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(St�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);

            // f�rsta kodet ner�t ska aktiver sj�lva spelet 
            // andra koden aktiverar grupprutan (gbxSpelet)
            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";

            // den h�ra koden s�tter antal gissningar till 0, Fr�n b�rjan.
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
                antalGissningar + " f�rs�k.";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true ;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " f�rs�k\n");

            }

            else if (gissaTal < datornsTal)
            {
                lblResultat.Text = "f�r l�gt. f�rs�k igen.";

            }
            else
            {
                lblResultat.Text = "f�r h�gt. f�rs�k igen.";
            }




        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            string St�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(St�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);


            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";

            antalGissningar = 0;
        }
    }
}