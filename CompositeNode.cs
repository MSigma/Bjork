using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjork
{
    /// <summary>
    /// The base node for most node types except for Decorators
    /// It's a Node with Children
    /// </summary>
    public abstract class CompositeNode : Node
    {
        public List<Node> Children
        {
            get { return _children; }
        }
        private List<Node> _children;

        public CompositeNode()
        {
            _children = new List<Node>();
        }

        public void AddNode(Node child)
        {
            _children.Add(child);
        }
    }
}
