using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjork
{
    /// <summary>
    /// A node type that loops through its children until any of them return Running or Failure
    /// If none return Running or Failure, it returns Success
    /// </summary>
    public class Sequence : CompositeNode
    {
        public override NodeResult Execute(double delta)
        {
            foreach (var child in Children)
            {
                var status = child.Execute(delta);
                if (status != NodeResult.Success)
                    return status;
            }

            return NodeResult.Success;
        }
    }
}
