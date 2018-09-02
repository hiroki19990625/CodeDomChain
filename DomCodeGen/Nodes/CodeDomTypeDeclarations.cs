using CodeDomChain.Nodes.Members;
using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomTypeDeclarations<P> : CodeDomTypeDeclarationBase<CodeTypeDeclaration, P> where P : ICodeTypeCollection
    {
        public CodeDomTypeDeclarations(string name, P parent) : base(name, parent)
        {
            this.Node.Name = name;
            this.Parent.Types.Add(this.Node);
        }

        public CodeDomTypeDeclarations<P> ContinueTypeDeclaration(string name)
        {
            return new CodeDomTypeDeclarations<P>(name, this.Parent);
        }
    }
}