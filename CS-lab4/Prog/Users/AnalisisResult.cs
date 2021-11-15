using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    class AnalisisResult {
        public uint analisisID { get; set; }
        public double temparature { get; set; }
        public string bloodTest { get; set; }
        public Dictionary<string,string> other { get; set; }

        public AnalisisResult() {
            analisisID = 0;
            temparature = 0;
            bloodTest = "";
            other = null;
        }

        public AnalisisResult(uint _analisisID, double _temparature, string _bloodTest, Dictionary<string,string> _other) {
            analisisID = _analisisID;
            temparature = _temparature;
            bloodTest = _bloodTest;
            other = _other;
        }
        
        public override string ToString() {
            int count = other != null ? other.Count : 0;
            var ret = String.Format("id - {0} : {1}*C, bloodTest - {2}, other - {3}. ", analisisID, temparature, bloodTest, count);
            if (count > 0) {
                foreach(var pair in other) {
                    ret += pair.ToString();
                }
            }
            return ret;
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

