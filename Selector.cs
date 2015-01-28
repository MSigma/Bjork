using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjork
{
    /// <summary>
    /// A node type that loops through its children until any of them return Running or Success
    /// If none return Running or Success, it returns Failure
    /// </summary>
    public class Selector : CompositeNode
    {
        public override NodeResult Execute(double delta)
        {
            foreach (var child in Children)
            {
                var status = child.Execute(delta);
                if (status != NodeResult.Failure)
                    return status;
            }

            return NodeResult.Failure;
        }
    }
}
