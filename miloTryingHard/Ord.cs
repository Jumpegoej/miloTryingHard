using System;
using System.Collections.Generic;

namespace miloTryingHard
{
    public class Ord
    {
        public Ord(List<string> ordsBøjning, Ordtype enOrdType) {

            EtOrd = ordsBøjning;
            EnOrdType = enOrdType;
        }

        public List<string> EtOrd { get; set; }
        public Ordtype EnOrdType { get; set; }

        public override string ToString()
        {
            string streng = "";
            foreach (var bøjning in EtOrd)
            {
                if (bøjning != "-")
                {
                    streng += bøjning + " ";
                }

            }
            return $"Bøjninger: {streng}, Ordtype: {EnOrdType}";
        }
    }
}
