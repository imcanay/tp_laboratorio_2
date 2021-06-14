using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IColoreable
    {
        bool PintarBase(ConsoleColor color);
        bool PintarSecundario(ConsoleColor color);
    }
}
