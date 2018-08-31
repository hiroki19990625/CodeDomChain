using System;
using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomTypeReference<P> : CodeDomNodeBase<CodeTypeReference, P> where P : ICodeTypeReferences
    {
        public CodeDomTypeReference(Type type, P parent) : base(parent)
        {
            this.Node = new CodeTypeReference(type);
            this.Parent.TypeReferences.Add(this.Node);
        }

        public CodeDomTypeReference<P> ContinueTypeReference(Type type)
        {
            return new CodeDomTypeReference<P>(type, this.Parent);
        }
    }
}