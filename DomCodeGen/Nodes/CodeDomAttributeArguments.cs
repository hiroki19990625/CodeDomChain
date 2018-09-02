using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomAttributeArguments<P> : CodeDomNodeBase<CodeAttributeArgument, P> where P : ICodeAttributeArgumentCollection
    {
        public CodeDomAttributeArguments(string name, P parent) : base(parent)
        {
            this.Node = new CodeAttributeArgument();
            this.Parent.Arguments.Add(this.Node);
        }

        public CodeDomAttributeArguments<P> ContinueAttributeArgument(string name)
        {
            return new CodeDomAttributeArguments<P>(name, this.Parent);
        }

        //TODO CodeExpression...
    }
}