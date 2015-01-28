using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bjork
{
    public abstract class Node
    {
        public abstract NodeResult Execute(double delta);
    }
}
