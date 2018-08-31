using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomAttributeArgument<P> : CodeDomNodeBase<CodeAttributeArgument, P> where P : ICodeDomAttributeArguments
    {
        public CodeDomAttributeArgument(string name, P parent) : base(parent)
        {
            this.Node = new CodeAttributeArgument();
            this.Parent.Arguments.Add(this.Node);
        }

        public CodeDomAttributeArgument<P> ContinueAttributeArgument(string name)
        {
            return new CodeDomAttributeArgument<P>(name, this.Parent);
        }

        //TODO CodeExpression...
    }
}