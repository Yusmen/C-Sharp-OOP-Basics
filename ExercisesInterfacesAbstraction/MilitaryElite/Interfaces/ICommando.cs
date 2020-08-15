using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        string Corps { get; set; }
        List<Mission> Missions { get; set; }

    }
}
