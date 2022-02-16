using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class Session
    {
        public int SessieNr { get; set; }
        public string Date { get; set; }
        public int KlantId { get; set; }
        public int TotTime { get; set; }
        public double AVGSpeed { get; set; }
        public List<int> Seqnr { get; set; }
        public List<int> SeqTime { get; set; }
        public List<double> SeqSpeed { get; set; }

        public Session(string session)
        {
            string[] value = session.Split(",");
            SessieNr = int.Parse(value[0]);
            Date = value[1].Replace("'", "");
            KlantId = int.Parse(value[2]);
            TotTime = int.Parse(value[3]);
            AVGSpeed = double.Parse(value[4].Replace(".", ","));
            Seqnr = new List<int>();
            SeqTime = new List<int>();
            SeqSpeed = new List<double>();
            Seqnr.Add(int.Parse(value[5]));
            SeqTime.Add(int.Parse(value[6]));
            SeqSpeed.Add(double.Parse(value[7].Replace(".", ",")));
        }

        public void AddSeq(string session)
        {
            string[] value = session.Split(",");
            Seqnr.Add(int.Parse(value[5]));
            SeqTime.Add(int.Parse(value[6]));
            SeqSpeed.Add(double.Parse(value[7].Replace(".", ",")));
        }
    }
}