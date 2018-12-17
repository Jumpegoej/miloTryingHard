using System;
using System.Collections.Generic;
using System.Linq;

namespace miloTryingHard 
{

    class MainClass 
    {

        private static List<string> rimListe;

        private static List<string> navneordStringListe;
        private static List<Ord> navneordsListe;

        private static List<string> udsagnsordStringListe;
        private static List<Ord> udsagnsordsListe;

        private static List<string> tillægsordsStringListe;
        private static List<Ord> tillægsordsListe;

        private static List<Ord> alleOrd;

        public const string sti = @"/Users/Helene/Documents/Programmering/Visual Studio/Milo <3/miloTryingHard/miloTryingHard/rimeOnTime.txt";
        public const string navneord = @"/Users/Helene/Documents/Programmering/Visual Studio/Milo <3/miloTryingHard/miloTryingHard/Text/nameWords.txt";
        public const string udsagnsord = @"/Users/Helene/Documents/Programmering/Visual Studio/Milo <3/miloTryingHard/miloTryingHard/Text/doWords.txt";
        public const string tillægsord = @"/Users/Helene/Documents/Programmering/Visual Studio/Milo <3/miloTryingHard/miloTryingHard/Text/addWords.txt";

        public static void Main(string[] args) 
        {
            IndlæsAlt();

            Console.WriteLine($"Find et {Ordtype}, der rimer på {alleOrd}. Go!");

            /*     var firstRime = new Rimes(9, "sovs", "smovs", Ordtype.Substantiv, Ordtype.Adjektiv);
                 rimListe.Add(firstRime.ToString());
                 Console.WriteLine(firstRime.ToString());

                 SkrivResultat(rimListe);


                 foreach (var ord in tillægsordsListe)
                 {
                     Console.WriteLine(ord);
                 }
                 Console.ReadKey(); */
        }


        //Functions:

        public static List<string> HentLinjer(string stien = sti) 
        {

            List<string> resultater = new List<string>();

            foreach (var nyLinie in System.IO.File.ReadLines(stien)) 
            {
                resultater.Add(nyLinie);
            }
           
           return resultater;
        }

        public static void SkrivResultat(List<string> listeAfResultater) 
        {

            System.IO.StreamWriter writer = new System.IO.StreamWriter(sti);

            foreach (var nyLinie in listeAfResultater) 
            {
                writer.WriteLine(nyLinie);
            }

            writer.Close();
        }

        public static List<Ord> SorterOrdPlusType(List<string> ordListe, Ordtype ordtype)
        {
            List<Ord> resultat = new List<Ord>();
            foreach (var linie in ordListe)
            {
                Ord nytOrd = new Ord(linie.Split(',').ToList(), ordtype);
                resultat.Add(nytOrd);
            }

            return resultat;
        }

        public static void IndlæsAlt()
        {
            rimListe = HentLinjer(sti);

            navneordStringListe = HentLinjer(navneord);
            navneordsListe = SorterOrdPlusType(navneordStringListe, Ordtype.Substantiv);

            udsagnsordStringListe = HentLinjer(udsagnsord);
            udsagnsordsListe = SorterOrdPlusType(udsagnsordStringListe, Ordtype.Verbum);

            tillægsordsStringListe = HentLinjer(tillægsord);
            tillægsordsListe = SorterOrdPlusType(tillægsordsStringListe, Ordtype.Adjektiv);

            alleOrd = new List<Ord>();
            foreach (var ord in navneordsListe)
            {
                alleOrd.Add(ord);
            }

            foreach (var ord in udsagnsordsListe)
            {
                alleOrd.Add(ord);
            }

            foreach (var ord in tillægsordsListe)
            {
                alleOrd.Add(ord);
            }
        }
    }
}
