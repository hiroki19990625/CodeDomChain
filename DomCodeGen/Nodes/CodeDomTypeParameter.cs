using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomTypeParameter<P> : CodeDomNodeBase<CodeTypeParameter, P> where P : ICodeTypeParameters
    {
        public CodeDomTypeParameter(string name, P parent) : base(parent)
        {
            this.Node = new CodeTypeParameter(name);
            this.Parent.TypeParameters.Add(this.Node);
        }

        public CodeDomTypeParameter<P> ContinueTypeReference(string name)
        {
            return new CodeDomTypeParameter<P>(name, this.Parent);
        }
    }
}
