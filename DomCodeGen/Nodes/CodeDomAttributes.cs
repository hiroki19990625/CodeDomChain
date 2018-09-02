using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomAttributes<P> : CodeDomNodeBase<CodeAttributeDeclaration, P>, ICodeAttributeArgumentCollection where P : ICodeAttributeCollection
    {
        public CodeAttributeArgumentCollection Arguments { get; } = new CodeAttributeArgumentCollection();

        public CodeDomAttributes(string name, P parent) : base(parent)
        {
            this.Node = new CodeAttributeDeclaration(name);
            this.Parent.Attributes.Add(this.Node);
        }

        public CodeDomAttributes<P> ContinueAttribute(string name)
        {
            return new CodeDomAttributes<P>(name, this.Parent);
        }
    }
}
