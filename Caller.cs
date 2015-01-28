using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjork
{
    public delegate NodeResult CallerDelegate(double delta);

    /// <summary>
    /// A wrapper for an action.
    /// </summary>
    public class Caller : Node
    {
        private CallerDelegate _action;

        public Caller(CallerDelegate action)
        {
            _action = action;
        }

        public override NodeResult Execute(double delta)
        {
            return _action(delta);
        }
    }
}
