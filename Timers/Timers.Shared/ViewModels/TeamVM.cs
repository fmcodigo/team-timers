using Timers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Shared.ViewModels
{
    public class TeamVM : Team
    {
        public List<Player> Players { get; set; }
    }
}
