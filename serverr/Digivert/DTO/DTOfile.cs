using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTOfile
    {
        public long Idfile { get; set; }
        public string idproject { get; set; }
        public string srcimagetarget { get; set; }
        public string newimagetarget { get; set; }
        public DTOfile()
        {
                
        }
        public DTOfile ( file u )
        {
            u.Idfile = Idfile;
            u.idproject = idproject;
            u.newimagetarget = newimagetarget;
            u.srcimagetarget = srcimagetarget;
        }
    }
}
