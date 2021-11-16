using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public struct AnalisisResultStruct : IDisposable
    {//модифікатор public
        public uint analisisID { get; set; }
        public double temparature { get; set; }
        public string bloodTest { get; set; }
        public Dictionary<string, string> other { get; set; }

        public AnalisisResultStruct(uint _analisisID, double _temparature, string _bloodTest, Dictionary<string, string> _other)
        {
            analisisID = _analisisID;
            temparature = _temparature;
            bloodTest = _bloodTest;
            other = _other;
        }

        public override string ToString()
        {
            int count = other?.Count ?? 0;
            var ret = $"id - {analisisID} : {temparature}*C, bloodTest - {bloodTest}, other - {count}. ";
            if (count > 0)
            {
                foreach (var pair in other)
                {
                    ret += pair.ToString();
                }
            }
            return ret;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        // public static string getParameter(this AnalisisResult res, string param) {
        //     if ( res.other == null ) { return null; }
        //     if (res.other.ContainsKey(param)) {
        //         return res.other[param];
        //     }
        //     return null;
        // }
    }
}
