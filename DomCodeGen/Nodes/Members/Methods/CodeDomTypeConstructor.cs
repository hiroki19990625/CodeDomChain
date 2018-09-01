using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomTypeConstructor<P> : CodeDomMemberMethodBase<CodeTypeConstructor, P> where P : ICodeTypeMembers
    {
        public CodeDomTypeConstructor(P parent) : base(parent)
        {
            this.Node.Name = "Constructor";
        }
    }
}