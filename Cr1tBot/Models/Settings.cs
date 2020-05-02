using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr1tBot.Models
{
    public class Settings
    {
        public string OAuth { get; set; }
        public string Username { get; set; }
        public bool FirstStartup { get; set; } = true;
        public List<Game> Games { get; set; }
        public List<Command> Commands { get; set; }
    }
}
