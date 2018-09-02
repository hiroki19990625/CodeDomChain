using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public class CodeDomTypeDeclaration<P> : CodeDomTypeDeclarationBase<CodeTypeDeclaration, P> where P : ICodeTypeMemberCollection
    {
        public CodeDomTypeDeclaration(string name, P parent) : base(name, parent)
        {
            this.Node.Name = name;
            this.Parent.TypeMembers.Add(this.Node);
        }

        public CodeDomTypeDeclaration<P> ContinueTypeDeclaration(string name)
        {
            return new CodeDomTypeDeclaration<P>(name, this.Parent);
        }
    }
}