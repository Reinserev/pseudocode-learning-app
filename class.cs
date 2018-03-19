using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudocode_Master
{
    //class @class
    //{
    //
    //}

    public class Verificare_Sintaxa
    {
        
        static string citiresc = Main_Window.citire + ' ', scrieresc = Main_Window.scriere + ' ';
        static string[] operatii = { Main_Window.citire + ' ', Main_Window.scriere + ' ', Main_Window.daca + ' ', Main_Window.cat_timp + ' ', Main_Window.pentru + ' ', Main_Window.repeta, Main_Window.pana_cand +' '};
        static string[] declarari = { Main_Window.natural, Main_Window.intreg, Main_Window.rational, Main_Window.real};
        static string[] declarari_corecte = { Main_Window.natural + ' ', Main_Window.intreg + ' ', Main_Window.rational + ' ', Main_Window.real + ' ' };
        static string[] chestii = { Main_Window.sfdaca, Main_Window.sfcattimp, Main_Window.sfpentru };

        public static bool verifica_prezenta_operatori (string sir)
        {
            int i;
            for (i = 0; i <= 11; i++)
                if (sir.Contains(Main_Window.operatori[i]) == true)
                    return false;
            return true;
        }

        public static bool verifica_virgule (string sir)
        {
            sir = sir.Replace(" ", "");
            int i = 0;
            string[] split = sir.Split(',');
            while (i < split.Length)
            {
                if (split[i].Length == 0)
                    return false;
                i++;
            }
            return true;
        }

        //--- SEPARATOR---

        public static bool verifica_declarare (string sir)
        {
            if (verifica_prezenta_operatori(sir) == false)
                return false;

            int i;

            for (i = 0; i <= 3; i++)
                if (sir.Contains(declarari[i]) == true && sir.Contains(declarari_corecte[i]) == false)
                    return false;

            for (i = 0; i <= 3; i++)
                sir = sir.Replace(declarari[i], "");
            sir = sir.Replace(" ", "");
            if (sir.Length == 0)
                return false;

            if (sir[0] >= '0' && sir[0] <= '9')
                return false;

            i = 0;
            string[] split = sir.Split(',');
            while (i < split.Length)
            {
                if(split[i].Length>=1)
                if (split[i][0] >= '0' && split[i][0] <= '9')
                    return false;
                i++;
            }

            return true;
        }

        public static bool verifica_citire (string sir)
        {
            if (sir.Contains(operatii[0]) == false)
                return false;
             sir = sir.Replace(operatii[0], "");

            if (verifica_prezenta_operatori(sir) == false)
                return false;

            return true;
        }

        public static bool verifica_scriere(string sir)
        {
            if (sir.Contains(operatii[1]) == false)
                return false;
            sir = sir.Replace(operatii[1], "");

            // operatorii sunt permisi la scriere !!

            return true;
        }

        public static bool verifica_atribuire(string sir)
        {
            if (sir.Contains(",") == true)
                return false;

            sir = sir.Replace("<-", "~");
            string[] lucru = sir.Split('~');
            if(verifica_prezenta_operatori(lucru[0])==false)
                    return false;

            return true;
        }

        public static bool verifica_decizie(string sir)
        {
            if (sir.Contains(operatii[2]) == false || sir.Contains("<-")==true || sir.Contains(",") == true)
                return false;
            return true;
        }

        public static bool verifica_cat_timp (string sir)
        {
            if (sir.Contains(operatii[3]) == false || sir.Contains("<-") == true|| sir.Contains(",") == true)
                return false;
            return true;
        }

        public static bool verifica_pentru (string sir)
        {
            if (sir.Contains(operatii[4]) == false || sir.Contains('=')==false)
                return false;

            sir = sir.Replace(Main_Window.pentru, "");
            sir = sir.Replace(Main_Window.executa, "");
            string[] lucru = sir.Split(',');
            string[] var = lucru[0].Split('=');
            string atribuire = var[0] + "<-" + var[1];
            string daca_conditie = Main_Window.daca + var[0] + "<=" + lucru[1];

            if (verifica_atribuire(atribuire) == false)
                return false;

            if (verifica_decizie(daca_conditie) == false)
                return false;

            //REFERINTA
            //sir = "for(" + var[0] + '=' + var[1] + ';' + var[0] + "<=" + lucru[1] + ';';

            if (lucru.GetUpperBound(0) == 2)
            {
                //REFERINTA
                //sir = sir + var[0] + '=' + var[0] + lucru[2];
                string alta_atribuire = var[0] + "<-" + var[0] + lucru[2];
                if (verifica_atribuire(alta_atribuire) == false)
                    return false;
            }
                
            sir = sir + ")\n" + sir;

            return true;
        }

        public static bool verifica_repeta(string sir)
        {
            if (sir.Contains(operatii[5]) == false || sir.Contains("<-") == true || sir.Contains(",") == true)
                return false;
            while (sir.Contains(" "))
                sir = sir.Replace(" ", "");
            sir = sir.Replace(operatii[5], "");
            if (sir.Length > 0)
                return false;
            return true;
        }

        public static bool verifica_prezenta_sir(string sir, string prezent)
        {
            if (sir.Contains(prezent) == false || sir.Contains("<-") == true || sir.Contains(",") == true)
                return false;
            sir = sir.Replace(prezent, "");
            if (sir.Length > 0)
                return false;
            return true;
        }

        public static bool verifica_sfarsituri (string sir)
        {
            int i;
            for (i = 0; i <= 2; i++)
                if (sir.Contains(chestii[i]) == true && Verificare_Sintaxa.verifica_prezenta_sir(sir, chestii[i]) == false)
                    return false;
            return true;
        }

        public static bool verifica_pana_cand(string sir)
        {
            if (sir.Contains(operatii[6]) == false || sir.Contains("<-") == true || sir.Contains(",") == true)
                return false;
            return true;
        }

        public static bool verifica_paranteze (string sir)
        {
            int c1 = 0, c2 = 0;
            int i;
            for (i = 0; i <= sir.Length - 1; i++)
            {
                if (sir[i] == '(')
                    c1++;
                if (sir[i] == ')')
                    c2++;
                if (c2 > c1)
                    return false;
            }
            if(c1!=c2)
                return false;
            return true;
        }

        public static bool verifica_operatori (string sir)
        {
        /*
        Operatori:
        + - * / DIV MOD
        < > <= >= = <>
        AND OR NOT XOR
        */
            while (sir.Contains("  "))
                sir = sir.Replace("  ", " ");

            sir = sir.Replace("<-", "+"); // nici atribuire si direct operator nu e corect !!

            sir = sir.Replace("-", "+");
            sir = sir.Replace("*", "+");
            sir = sir.Replace("/", "+");
            sir = sir.Replace("DIV", "+");
            sir = sir.Replace("MOD", "+");

            sir = sir.Replace(">", "+");
            sir = sir.Replace("<=", "+");
            sir = sir.Replace(">=", "+");
            sir = sir.Replace("=", "+");
            sir = sir.Replace("<>", "+");

            sir = sir.Replace("AND", "+");
            sir = sir.Replace("OR", "+");
            sir = sir.Replace("NOT", "+");
            sir = sir.Replace("XOR", "+");


            if (sir.Contains("++") == true || sir.Contains("+)")==true)
                return false;

            return true;
        }

        public static bool verifica_sintaxa (string sir)
        {
            if (sir.Contains(Main_Window.daca) == true && sir.Contains(Main_Window.atunci) == false)
                return false;
            if (sir.Contains(Main_Window.cat_timp) == true && sir.Contains(Main_Window.executa) == false)
                return false;
            if (sir.Contains(Main_Window.pentru) == true && sir.Contains(Main_Window.executa) == false)
                return false;

            if (sir.Contains(Main_Window.daca) == true && sir.Contains(Main_Window.sfdaca) == false)
                return false;
            if (sir.Contains(Main_Window.cat_timp) == true && sir.Contains(Main_Window.sfcattimp) == false)
                return false;
            if (sir.Contains(Main_Window.pentru) == true && sir.Contains(Main_Window.sfpentru) == false)
                return false;
            if (sir.Contains(Main_Window.repeta) == true && sir.Contains(Main_Window.pana_cand) == false)
                return false;

            if (sir.Contains(Main_Window.repeta) == false && sir.Contains(Main_Window.pana_cand) == true)
                return false;

            return true;
        }

        public static bool verifica_caractere (string sir)
        {
            string caractere_admise = "+-*/<>= .;,\"";
            int i;
            for (i = 0; i <= sir.Length - 1; i++)
                if(char.IsLetter(sir[i])==false && char.IsNumber(sir[i])==false)
                    if (caractere_admise.IndexOf(sir[i]) == -1)
                        return false;
            return true;
        }

        static public char stuff;

        static bool sem = false;

        public static bool verifica_acuratete (string sir)
        {
            int i;
            for (i = 0; i <= 3; i++)
                if (sir.Contains(declarari[i]) == true)
                    return true;

            if (sir.Contains("<-") == true)
                return true;

            if (sir.Contains(Main_Window.citire) == true)
                return true;

            if (sir.Contains(Main_Window.scriere) == true)
                return true;

            if (sir.Contains(Main_Window.daca) == true)
                return true;

            if (sir.Contains(Main_Window.altfel) == true)
                return true;

            if (sir.Contains(Main_Window.sfdaca) == true)
                return true;

            if (sir.Contains(Main_Window.cat_timp) == true)
                return true;

            if (sir.Contains(Main_Window.sfcattimp) == true)
                return true;

            if (sir.Contains(Main_Window.pentru) == true)
                return true;

            if (sir.Contains(Main_Window.sfpentru) == true)
                return true;

            if (sir.Contains(Main_Window.repeta) == true)
                return true;

            if (sir.Contains(Main_Window.pana_cand) == true)
                return true;

            return false;
        }

        public static string conversie(string input, ref bool SEMAFOR)
        {
            string output;
            output = input; // string de lucru

            output = output.Replace(";", ""); // corecteaza ; puse aiurea, fiindca in pseudocod nu ar trebui sa existe ;

            sem = false;

            while (output.Contains("  ") == true) //corecteaza spatiile multiple
                output = output.Replace("  ", " ");

            // --- SEPARATOR

            if (Verificare_Sintaxa.verifica_virgule(output) == false)
                sem = true;

            if (Verificare_Sintaxa.verifica_paranteze(output) == false)
                sem = true;

            if (Verificare_Sintaxa.verifica_operatori(output) == false)
                sem = true;

            // --- SEPARATOR
            // declar, atribui, citesc, scriu, if, while, for, repeat until

            if (output.Contains(Main_Window.natural) == true || output.Contains(Main_Window.intreg) == true || output.Contains(Main_Window.rational) == true || output.Contains(Main_Window.real) == true)
                if (Verificare_Sintaxa.verifica_declarare(output) == false)
                    sem = true;

            if (output.Contains("<-") == true)
            {
                if (Verificare_Sintaxa.verifica_atribuire(output) == false)
                    sem = true;
            }

            if (output.Contains(Main_Window.citire) == true)
                if (Verificare_Sintaxa.verifica_citire(output) == false)
                    sem = true;

            if (output.Contains(Main_Window.scriere) == true)
                if (Verificare_Sintaxa.verifica_scriere(output) == false)
                    sem = true;

            if (output.Contains(Main_Window.daca) == true && output.Contains(Main_Window.sfdaca) == false)
                if (Verificare_Sintaxa.verifica_decizie(output) == false)
                    sem = true;

            if (output.Contains(Main_Window.cat_timp) == true && output.Contains(Main_Window.sfcattimp) == false)
                if (Verificare_Sintaxa.verifica_cat_timp(output) == false)
                    sem = true;

            if (output.Contains(Main_Window.pentru) == true && output.Contains(Main_Window.sfpentru) == false)
                if (Verificare_Sintaxa.verifica_pentru(output) == false)
                    sem = true;

            if (output.Contains(Main_Window.repeta) == true)
                if (Verificare_Sintaxa.verifica_repeta(output) == false)
                    sem = true;

            if (output.Contains(Main_Window.pana_cand) == true)
                if (Verificare_Sintaxa.verifica_pana_cand(output) == false)
                    sem = true;

            if (Verificare_Sintaxa.verifica_sfarsituri(output) == false)
                sem = true;

            if (Verificare_Sintaxa.verifica_caractere(output) == false)
                sem = true;

            if (Verificare_Sintaxa.verifica_acuratete(output) == false)
                sem = true;

            if (sem == true)
                SEMAFOR = true;

            return output;
        }

    }
}
