using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomTypeParameters<P> : CodeDomNodeBase<CodeTypeParameter, P> where P : ICodeTypeParameterCollection
    {
        public CodeDomTypeParameters(string name, P parent) : base(parent)
        {
            this.Node = new CodeTypeParameter(name);
            this.Parent.TypeParameters.Add(this.Node);
        }

        public CodeDomTypeParameters<P> ContinueTypeReference(string name)
        {
            return new CodeDomTypeParameters<P>(name, this.Parent);
        }
    }
}
