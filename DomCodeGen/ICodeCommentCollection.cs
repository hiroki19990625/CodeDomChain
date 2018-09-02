using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeCommentCollection
    {
        CodeCommentStatementCollection Comments { get; }
    }
}
