using System.Collections.Generic;

namespace Chromatik.Classes
{
    public class Command
    {
        public int user_id { get; set; }
        public List<CommandDetail> command_details { get; set; }
    }
}
