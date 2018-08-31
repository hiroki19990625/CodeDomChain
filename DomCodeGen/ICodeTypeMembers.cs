using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeMembers
    {
        CodeTypeMemberCollection TypeMembers { get; }
    }
}