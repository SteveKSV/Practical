using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Interfaces
{
    public interface IJob
    {
        string Name { get; }

        int RequiredHoursOfWork { get; }

        void Update();
    }
}
