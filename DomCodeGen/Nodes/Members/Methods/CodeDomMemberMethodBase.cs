using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomMemberMethodBase<N, P> : CodeDomTypeMember<N, P> where N : CodeMemberMethod, new() where P : ICodeTypeMembers
    {
        public CodeDomMemberMethodBase(P parent) : base(parent)
        {

        }
    }
}