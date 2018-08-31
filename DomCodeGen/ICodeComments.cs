using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeComments
    {
        CodeCommentStatementCollection Comments { get; }
    }
}
