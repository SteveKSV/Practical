using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        List<IPrivate> Privates { get; set; }
    }
}
