using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarchenkoSchool.DbEntity
{
    public static class DbStorage
    {
        public static HorseSchoolPPEntities DB_s { get; set; } = new HorseSchoolPPEntities();
    }
}
