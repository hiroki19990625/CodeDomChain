using System;
using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomTypeReference<P> : CodeDomNodeBase<CodeTypeReference, P> where P : ICodeTypeReference
    {
        public CodeDomTypeReference(Type type, P parent) : base(parent)
        {
            this.Node = new CodeTypeReference(type);
            this.Parent.TypeReference = this.Node;
        }

        public CodeDomTypeReference(string type, P parent) : base(parent)
        {
            this.Node = new CodeTypeReference(type);
            this.Parent.TypeReference = this.Node;
        }
    }
}