using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeMemberCollection
    {
        CodeTypeMemberCollection TypeMembers { get; }
    }
}