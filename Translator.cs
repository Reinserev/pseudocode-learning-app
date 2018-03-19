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
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
            this.Text = Main_Window.tradu;
            Action.Text = Main_Window.translate_now;
            LanguageToCPP();
        }

        public static string citeste, scrie, incepe, termina;
        public static string natural, intreg, rational, real;
        public static string equal, not_equal, div, mod;
        public static string and, or, not;
        public static string assignment, repeta, pana_cand;
        public bool existaaltfel;
        public char stuff;
        StreamReader f1;
        bool iscplusplus;
        bool REPEAT=false;
        string for_pascalian = "";

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslateFrom.Text = TranslateTo.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "Text Files|*.txt";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TranslateFrom.LoadFile(openFile1.FileName,RichTextBoxStreamType.PlainText);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text Files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
                TranslateTo.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(TranslateTo.Text);
                TranslateTo.Text = "";
            }
            catch
            {
                ;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(TranslateTo.Text);
            }
            catch
            {
                ;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TranslateFrom.Text = TranslateFrom.Text + Clipboard.GetText();
            }
            catch
            {
                ;
            }
        }

        bool verificare_preliminara (RichTextBox Verificator)
        {
            bool SEMAFOR = false;

            if (Verificator.Text != "")
            {
                string code, translated;
                code = Verificator.Text;
                string[] split = code.Split('\n');
                int i = 0;
                Verificator.Text = "";
                while (i < split.Length && SEMAFOR == false)
                {
                    translated = split[i];
                    translated = Verificare_Sintaxa.conversie(translated, ref SEMAFOR);
                    Verificator.Text = Verificator.Text + translated;
                    if (translated != "")
                        Verificator.Text = Verificator.Text + '\n';
                    i++;
                }
            }

            if (SEMAFOR == true)
                return false;
            else
            {
                if (Verificare_Sintaxa.verifica_sintaxa(Verificator.Text) == true)
                    return true;
                else
                    return false;
            }
        }

        private string cpluspluslogical (string input)
        {
            string output = input;
            output = output.Replace("AND", and);
            output = output.Replace("OR", or);
            output = output.Replace("NOT", not);
            output = output.Replace("=", equal);
            output = output.Replace("<>", not_equal);
            return output;
        }

        private string conversie(string input)
        {
            if (input == "")
            {
                stuff = '\0';
                return null; }

            stuff = '\n';

            string output;
            output = input; // string de lucru
            bool nopunctsivirgula = false;

            output = output.Replace(";", ""); // corecteaza ; puse aiurea

            while (output.Contains("  ") == true) //corecteaza spatiile multiple
                output = output.Replace("  ", " ");

            //citirea
            if (output.Contains(Main_Window.citire) == true)
            {
                output = output.Replace(Main_Window.citire, citeste);
                if (iscplusplus == true)
                    output = output.Replace(",", ">>");
                else
                    output = output + ')';
            }

            //scrierea
            if (output.Contains(Main_Window.scriere) == true)
            {
                output = output.Replace(Main_Window.scriere, scrie);
                if (iscplusplus == true)
                    output = output.Replace(",", "<<");
                else
                    output = output + ')';
            }

            //declararea
            output = output.Replace(Main_Window.natural, natural);
            output = output.Replace(Main_Window.intreg, intreg);
            output = output.Replace(Main_Window.rational, rational);
            output = output.Replace(Main_Window.real, real);

            //atribuire
            if (output.Contains("<-") == true && output.Contains(Main_Window.pentru) == false)
                output = output.Replace("<-", assignment);

            //decizie
            if (output.Contains(Main_Window.daca) == true && output.Contains(Main_Window.sfdaca) == false)
            {
                nopunctsivirgula = true;
                output = output.Replace(Main_Window.daca, "");
                output = output.Replace(Main_Window.atunci, "#");
                string[] lucru = output.Split('#');
                if (iscplusplus == true)
                    lucru[0] = cpluspluslogical(lucru[0]);
                if (iscplusplus == true)
                    output = "if (" + lucru[0] + ')' + '\n' + incepe + '\n' + conversie(lucru[1]);
                else
                    output = "if " + lucru[0] + "then" + '\n' + incepe + '\n' + conversie(lucru[1]);
            }

            if (output.Contains(Main_Window.altfel) == true)
            {
                output = termina + ';' + '\n' + output.Replace(Main_Window.altfel, "else\n" + incepe);
                existaaltfel = true;
            }

            if (output.Contains(Main_Window.sfdaca) == true)
            {
                if (existaaltfel == true)
                { output = output.Replace(Main_Window.sfdaca, termina); existaaltfel = false; }
                else
                    output = termina;
            }

            //repetitiva conditionata anterior
            if (output.Contains(Main_Window.cat_timp) == true && output.Contains(Main_Window.sfcattimp) == false)
            {
                nopunctsivirgula = true;
                output = output.Replace(Main_Window.cat_timp, "");
                output = output.Replace(Main_Window.executa, "#");
                string[] lucru = output.Split('#');
                if (iscplusplus == true)
                    lucru[0] = cpluspluslogical(lucru[0]);
                if (iscplusplus == true)
                    output = "while (" + lucru[0] + ')' + '\n' + incepe + '\n' + conversie(lucru[1]);
                else
                    output = "while " + lucru[0] + "do" + '\n' + incepe + '\n' + conversie(lucru[1]);
            }

            output = output.Replace(Main_Window.sfcattimp, termina);

            //repetitiva cu numar cunoscut de pasi
            if (output.Contains(Main_Window.pentru)==true && output.Contains(Main_Window.sfpentru) == false)
            {
                if(iscplusplus==false)
                {
                    /*
                    //suporta doar incremente, bun pentru Pascal
                    output=output.Replace(Main_Window.pentru,"for") ;
                    output = output.Replace(Main_Window.executa, "do");
                    output = output.Replace(",", " to ");
                    output = output.Replace("=", ":=");
                    output = output + '\n' + incepe;
                    */

                    output = output.Replace(Main_Window.pentru, "");
                    output = output.Replace(Main_Window.executa, "");
                    string[] lucru = output.Split(',');
                    string[] var = lucru[0].Split('=');
                    output = "for " + var[0] + ":=" + var[1] + " to " + lucru[1] + " do \n"+incepe;
                    if (lucru.GetUpperBound(0) == 2)
                        for_pascalian = var[0] + ":=" + var[0] + lucru[2]+';';
                }
                else
                {
                    output = output.Replace(Main_Window.pentru, "");
                    output = output.Replace(Main_Window.executa, "");
                    string[] lucru = output.Split(',');
                    string[] var = lucru[0].Split('=');
                    output = "for(" + var[0] + '=' + var[1] + ';' + var[0] + "<=" + lucru[1]+';';
                    if (lucru.GetUpperBound(0)==1)
                        output = output + var[0] + "++";
                    else
                        output = output +var[0]+'='+var[0]+lucru[2];
                    output = output + ")\n" + incepe;
                }
            }
            if (output.Contains(Main_Window.sfpentru)==true && iscplusplus == false && for_pascalian.Length!=0)
            {
                output = output.Replace(Main_Window.sfpentru, "");
                output = output + for_pascalian + '\n' +termina+';';
                for_pascalian = "";
            }
            if(output.Contains(Main_Window.sfpentru) == true && iscplusplus == false)
                output = output.Replace(Main_Window.sfpentru, termina+';');
            if (iscplusplus==true)
                output = output.Replace(Main_Window.sfpentru, termina);

            //repetitiva conditionata posterior
                if (output.Contains(Main_Window.repeta)==true)
            {
                output = repeta+'\n'+incepe+'\n';
                nopunctsivirgula = true;
                stuff = '\0';
                REPEAT = true;
            }

            if (output.Contains(Main_Window.pana_cand) == true && REPEAT == true)
            {
                output = output.Replace(Main_Window.pana_cand, "");
                if (iscplusplus == true)
                { output = cpluspluslogical(output); output = "}\nwhile (NOT(" + output + "))"; }
                else
                    output = termina+';'+'\n'+pana_cand + output;
                REPEAT = false;
            }

            if (nopunctsivirgula==false && output.Contains(incepe)==false && output[output.Length-1]!=';')
                output = output + ';'; //adauga ; dupa oricare

            while (output.Contains("  ") == true) //corecteaza spatiile multiple
                output = output.Replace("  ", " ");

            // DIV si MOD
            if(iscplusplus == true)
            {
                output = output.Replace("MOD", mod);
                output = output.Replace("DIV", div);
            }

            return output;
        }

        private void Action_Click(object sender, EventArgs e)
        {
            if (TranslateFrom.Text != "")
            {
                if (verificare_preliminara(TranslateFrom) == true)
                {
                    string code, translated;
                    code = TranslateFrom.Text;
                    string[] split = code.Split('\n');
                    int i = 0;
                    TranslateTo.Text = "";
                    while (i < split.Length)
                    {
                        translated = split[i];
                        translated = conversie(translated);
                        TranslateTo.Text = TranslateTo.Text + translated + stuff;
                        i++;
                    }
                }
                else
                    TranslateTo.Text = Main_Window.gresit;
            }
        }

        private void ApplyNewLanguage ()
        {
            citeste = f1.ReadLine();
            scrie = f1.ReadLine();
            incepe = f1.ReadLine();
            termina = f1.ReadLine();
            natural = f1.ReadLine();
            intreg = f1.ReadLine();
            rational = f1.ReadLine();
            real = f1.ReadLine();
            equal = f1.ReadLine();
            not_equal = f1.ReadLine();
            div = f1.ReadLine();
            mod = f1.ReadLine();
            and = f1.ReadLine();
            or = f1.ReadLine();
            not = f1.ReadLine();
            assignment = f1.ReadLine();
            repeta = f1.ReadLine();
            pana_cand = f1.ReadLine();
        }

        private void LanguageToCPP ()
        {
            f1 = new StreamReader(@"..\..\Resources\cplusplus.txt");
            iscplusplus = true;
            ApplyNewLanguage();
        }

        private void LanguageToPascal ()
        {
            f1 = new StreamReader(@"..\..\Resources\pascal.txt");
            iscplusplus = false;
            ApplyNewLanguage();
        }

        private void cplusplus_Click(object sender, EventArgs e)
        {
            LanguageToCPP();
        }

        private void pascal_Click(object sender, EventArgs e)
        {
            LanguageToPascal();
        }
    }
}
