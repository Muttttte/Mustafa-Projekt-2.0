namespace Mustafa_Projekt
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            lbxSt�rstaTalet.Items.Add(10);
            lbxSt�rstaTalet.Items.Add(20);
            
            lbxSt�rstaTalet.SelectedItem = lbxSt�rstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
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