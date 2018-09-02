using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomMemberMethodBase<N, P> : CodeDomTypeMember<N, P>, ICodeAttributeCollection, ICodeCommentCollection where N : CodeMemberMethod, new() where P : ICodeTypeMemberCollection
    {
        public CodeDomMemberMethodBase(P parent) : base(parent)
        {

        }
    }
}