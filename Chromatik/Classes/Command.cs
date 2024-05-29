using Chromatik.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatik.Classes
{
    public class Command
    {
        public int user_id { get; set; }
        public List<CommandDetail> command_details { get; set; }
    }
}
