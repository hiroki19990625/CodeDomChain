using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomAttribute<P> : CodeDomNodeBase<CodeAttributeDeclaration, P>, ICodeDomAttributeArguments where P : ICodeAttributes
    {
        public CodeAttributeArgumentCollection Arguments { get; } = new CodeAttributeArgumentCollection();

        public CodeDomAttribute(string name, P parent) : base(parent)
        {
            this.Node = new CodeAttributeDeclaration(name);
            this.Parent.Attributes.Add(this.Node);
        }

        public CodeDomAttribute<P> ContinueAttribute(string name)
        {
            return new CodeDomAttribute<P>(name, this.Parent);
        }
    }
}
