using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Curso2.Entities.Entities_Modelo13
{
    public class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }


        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord)) { return false; }

            LogRecord other = (LogRecord)obj;
            return Username.Equals(other.Username);
        }


    }
}
