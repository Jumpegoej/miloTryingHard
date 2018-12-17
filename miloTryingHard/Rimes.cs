using System;
namespace miloTryingHard
{
    public class Rimes
    {
        private int tid;

        public override string ToString()
        {
            return $"Tid: {Tid.ToString()}, Rim: {OrdEt}, {OrdTo}, Ordtype: {OrdtypeEt}, Ordtype: {OrdtypeTo}";
        }

        public Rimes(int tid, string ordEt, string ordTo,
        Ordtype ordtypeEt, Ordtype ordtypeTo) {
            Tid = tid;
            OrdEt = ordEt;
            OrdTo = ordTo;
            OrdtypeEt = ordtypeEt;
            OrdtypeTo = ordtypeTo;
        }

        public int Tid {
            get {
                return tid;
            }
            set {
                tid = value;
            }
        }

        public string OrdEt { get; set; }
        public string OrdTo { get; set; }
        public Ordtype OrdtypeEt { get; set; }
        public Ordtype OrdtypeTo { get; set; }
    } 

    public enum Ordtype
    {
        Substantiv,
        Verbum,
        Adjektiv
    }



}

