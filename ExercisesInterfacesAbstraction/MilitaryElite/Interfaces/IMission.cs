using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface IMission
    {

        string CodeName { get; set; }
        string State { get; set; }
        void CompleteMission();


    }
}
