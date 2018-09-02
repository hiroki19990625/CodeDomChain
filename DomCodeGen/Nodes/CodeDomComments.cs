using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomComments<P> : CodeDomNodeBase<CodeCommentStatement, P> where P : ICodeCommentCollection
    {
        public CodeDomComments(string text, P parent) : base(parent)
        {
            this.Node = new CodeCommentStatement(text);
            this.Parent.Comments.Add(this.Node);
        }

        public CodeDomComments(string text, bool docComment, P parent) : base(parent)
        {
            this.Node = new CodeCommentStatement(text, docComment);
            this.Parent.Comments.Add(this.Node);
        }

        public CodeDomComments<P> ContinueComment(string text)
        {
            return new CodeDomComments<P>(text, this.Parent);
        }

        public CodeDomComments<P> ContinueComment(string text, bool docComment)
        {
            return new CodeDomComments<P>(text, docComment, this.Parent);
        }
    }
}