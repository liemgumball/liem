using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DB
    {
        public List<SV> db { get; set; }
        public static List<string> lopSHs { get; set; }
        public static List<string> sortModes { get; set; }
        public DB()
        {
            db = new List<SV>();
            db.AddRange(new SV[]
            {
                new SV("123190089","Liem","19PFIEV3",true,DateTime.Today,9.0,true,true,true),
                new SV("123190090","Hoang","19PFIEV1",true,DateTime.Today,7.0,true,true,true),
                new SV("123190091","Duc","19PFIEV2",true,DateTime.Today,5.0,true,true,true),
                new SV("123190088","Le","19PFIEV3",true,DateTime.Today,8.0,true,true,true),
            });
            lopSHs = new List<string>();
            lopSHs.AddRange(new string[]
            {
                "19PFIEV1", "19PFIEV2", "19PFIEV3","20PFIEV1", "20PFIEV2", "20PFIEV3"
            });
            sortModes = new List<string>();
            sortModes.AddRange(new string[]
            {
                "MSSV",
                "Name",
                "Diem"
            });
        }
    }
}
