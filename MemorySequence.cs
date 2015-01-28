using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjork
{
    /// <summary>
    /// The Memory Sequence is like a Sequence, but will start from the index of the last Running child
    /// until a Success or Failure is reached
    /// </summary>
    public class MemorySequence : CompositeNode
    {
        private int _lastNode = 0;

        public override NodeResult Execute(double delta)
        {
            for (; _lastNode < Children.Count; _lastNode++)
            {
                var child = Children[_lastNode];
                var status = child.Execute(delta);

                if (status == NodeResult.Failure)
                {
                    _lastNode = 0;
                    return NodeResult.Failure;
                }
                else if (status == NodeResult.Running)
                    return NodeResult.Running;
            }

            _lastNode = 0;
            return NodeResult.Success;
        }
    }
}
