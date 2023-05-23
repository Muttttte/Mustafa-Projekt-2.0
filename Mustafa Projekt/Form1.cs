namespace Mustafa_Projekt
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
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