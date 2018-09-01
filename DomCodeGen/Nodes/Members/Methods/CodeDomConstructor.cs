using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomConstructor<P> : CodeDomMemberMethodBase<CodeConstructor, P> where P : ICodeTypeMembers
    {
        public CodeDomConstructor(P parent) : base(parent)
        {
            this.Node.Name = "Constructor";
        }
    }
}