using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Player
    {
        public string  PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string TeamId { get; set; }
        public Team Team { get; set; }
    }
}
