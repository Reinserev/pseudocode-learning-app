using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pseudocode_Master
{
    public partial class Main_Window : Form
    {
        public static string citire, scriere, declarare, atribuie, daca, atunci, altfel, pentru, cat_timp, executa, temp, repeta, pana_cand, sfdaca, sfcattimp, sfpentru;
        public static string bun_venit, selecteaza, tradu, invata, construieste, verifica, help, facut, copyright;
        public static string translate_now, check_now;
        public static string natural, intreg, rational, real;
        public static bool limba;

        private void ExclamationBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(capiche);
        }

        public static string gresit, corect;
        public static string atentie, avertisment, capiche, prima_data, prima_linie, alt_avertisment;
        public static string help_translator, help_codechecker, help_learningenvironment, help_builder, help_help;
        public static string selecteaza_instructiunea, general, arata, ascunde;
        public static string thanks, open_gallery, next, previous;

        public static string[] DECLAR = new string[4];
        public static string[] ATRIBUI = new string[4];
        public static string[] CITESC = new string[4];
        public static string[] SCRIU = new string[4];
        public static string[] DACA = new string[18];
        public static string[] CAT_TIMP = new string[6];
        public static string[] PENTRU = new string[11];
        public static string[] REPETA_PANA_CAND = new string[7];

        public static string equal = "=", not_equal = "<>", smaller = "<", smaller_or_equal = "<=", higher = ">", higher_or_equal = ">=", and="AND", not="NOT", or="OR", div="DIV", MOD="MOD";
        public static string[] operatori = { "+", "-", "*", "/", "DIV", "MOD", "<", ">", "AND", "OR", "NOT", "XOR" };
        string[] split;
        StreamReader f1;

        public Main_Window()
        {
            InitializeComponent();
            LanguageChooser.Text = "English";
            LanguageToEnglish();

            DialogResult dialogResult = MessageBox.Show(avertisment, atentie, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Nag h = new Nag(capiche+"\n\n"+prima_data);
                h.Show();

                Learning g = new Learning();
                g.Show();

                Help f = new Help();
                f.Show();

                this.WindowState = FormWindowState.Minimized;
            }
        }

        void ApplyNewLanguage ()
        {
            citire = f1.ReadLine();
            scriere = f1.ReadLine();
            declarare = f1.ReadLine();
            atribuie = f1.ReadLine();
            daca = f1.ReadLine();
            atunci = f1.ReadLine();
            altfel = f1.ReadLine();
            pentru = f1.ReadLine();
            cat_timp = f1.ReadLine();
            executa = f1.ReadLine();

            temp = f1.ReadLine();
            split = temp.Split('/');
            repeta = split[0];
            pana_cand = split[1];

            sfdaca = f1.ReadLine();
            sfcattimp = f1.ReadLine();
            sfpentru = f1.ReadLine();

            temp = f1.ReadLine();

            bun_venit = f1.ReadLine();
            selecteaza = f1.ReadLine();
            tradu = f1.ReadLine();
            invata = f1.ReadLine();
            construieste = f1.ReadLine();
            verifica = f1.ReadLine();
            help = f1.ReadLine();
            facut = f1.ReadLine();
            copyright = f1.ReadLine();

            temp = f1.ReadLine();

            translate_now = f1.ReadLine();
            check_now = f1.ReadLine();
            selecteaza_instructiunea = f1.ReadLine();
            general = f1.ReadLine();
            arata = f1.ReadLine();
            ascunde = f1.ReadLine();
            thanks = f1.ReadLine();
            open_gallery = f1.ReadLine();
            next = f1.ReadLine();
            previous = f1.ReadLine();
            alt_avertisment = f1.ReadLine();

            Welcome.Text = bun_venit;
            SelectOption.Text = selecteaza;
            EnterTranslator.Text = tradu;
            EnterLearning.Text = invata;
            EnterBuilder.Text = construieste;
            EnterCodeChecker.Text = verifica;
            EnterHelp.Text = help;
            VSver.Text = facut;
            Copyright.Text = copyright;

            temp = f1.ReadLine();

            natural = f1.ReadLine();
            intreg = f1.ReadLine();
            rational = f1.ReadLine();
            real = f1.ReadLine();

            temp = f1.ReadLine();

            gresit = f1.ReadLine();
            corect = f1.ReadLine();

            temp = f1.ReadLine();

            atentie = f1.ReadLine();
            avertisment = f1.ReadLine();
            capiche = f1.ReadLine();
            prima_data = f1.ReadLine();
            prima_linie = f1.ReadLine();

            temp = f1.ReadLine();

            help_translator = f1.ReadLine();
            help_learningenvironment = f1.ReadLine();
            help_builder = f1.ReadLine();
            help_codechecker = f1.ReadLine();
            help_help = f1.ReadLine();

            temp = f1.ReadLine();

            int i;
            for(i=0;i<=3;i++)
                DECLAR[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 3; i++)
                ATRIBUI[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 3; i++)
                CITESC[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 3; i++)
                SCRIU[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 17; i++)
                DACA[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 5; i++)
                CAT_TIMP[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 10; i++)
                PENTRU[i] = f1.ReadLine();
            temp = f1.ReadLine();
            for (i = 0; i <= 6; i++)
                REPETA_PANA_CAND[i] = f1.ReadLine();
            temp = f1.ReadLine();
        }

        void LanguageToEnglish ()
        {
            limba = true;
            f1 = new StreamReader(@"..\..\Resources\EN.txt");
            ApplyNewLanguage();
        }

        void LanguageToRomanian()
        {
            limba = false;
            f1 = new StreamReader(@"..\..\Resources\RO.txt");
            ApplyNewLanguage();
        }

        void LanguageToOther()
        {
            limba = false;
            f1 = new StreamReader(@"..\..\Resources\OTHER.txt");
            ApplyNewLanguage();
        }

        private void EnterTranslator_Click(object sender, EventArgs e)
        {
            Translator f = new Translator();
            f.Show();
        }

        private void EnterLearning_Click(object sender, EventArgs e)
        {
            Learning f = new Learning();
            f.Show();
        }

        private void EnterBuilder_Click(object sender, EventArgs e)
        {
            Builder f = new Builder();
            f.Show();
        }

        private void EnterCodeChecker_Click(object sender, EventArgs e)
        {
            CodeChecker f = new CodeChecker();
            f.Show();
        }

        private void EnterHelp_Click(object sender, EventArgs e)
        {
            Help f = new Help();
            f.Show();
        }

        private void Main_Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(thanks);
            Application.Exit();
        }

        private void LanguageChooser_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.Compare(LanguageChooser.Text,"Romanian")==0)
                LanguageToRomanian();
            if (String.Compare(LanguageChooser.Text, "Other") == 0)
                LanguageToOther();
            if (String.Compare(LanguageChooser.Text, "English") == 0)
                LanguageToEnglish();
        }
    }
}
