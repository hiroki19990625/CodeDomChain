using System;
using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomTypeReferences<P> : CodeDomNodeBase<CodeTypeReference, P> where P : ICodeTypeReferenceCollection
    {
        public CodeDomTypeReferences(Type type, P parent) : base(parent)
        {
            this.Node = new CodeTypeReference(type);
            this.Parent.TypeReferences.Add(this.Node);
        }

        public CodeDomTypeReferences(string type, P parent) : base(parent)
        {
            this.Node = new CodeTypeReference(type);
            this.Parent.TypeReferences.Add(this.Node);
        }

        public CodeDomTypeReferences<P> ContinueTypeReference(Type type)
        {
            return new CodeDomTypeReferences<P>(type, this.Parent);
        }

        public CodeDomTypeReferences<P> ContinueTypeReference(string type)
        {
            return new CodeDomTypeReferences<P>(type, this.Parent);
        }
    }
}