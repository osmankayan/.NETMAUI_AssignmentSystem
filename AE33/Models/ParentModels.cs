using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE33.Models
{
    public class ParentModels
    {
        [PrimaryKey, AutoIncrement]
        public int P_ID{ get; set; }
        public string P_Name{ get; set; }
        public string P_L_Name{ get; set; }
        public string P_Tel{ get; set; }
        public string P_Mother_Father{ get; set; }
    }
}
