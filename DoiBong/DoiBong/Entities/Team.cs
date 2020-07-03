using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Team
    {
        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
