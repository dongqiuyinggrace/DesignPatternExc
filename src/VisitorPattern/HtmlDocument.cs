using System.Collections.Generic;

namespace DesignPatternExc.src.VisitorPattern
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void AddNode(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach(var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}