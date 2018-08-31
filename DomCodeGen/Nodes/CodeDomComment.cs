using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomComment<P> : CodeDomNodeBase<CodeCommentStatement, P> where P : ICodeComments
    {
        public CodeDomComment(string text, P parent) : base(parent)
        {
            this.Node = new CodeCommentStatement(text);
            this.Parent.Comments.Add(this.Node);
        }

        public CodeDomComment(string text, bool docComment, P parent) : base(parent)
        {
            this.Node = new CodeCommentStatement(text, docComment);
            this.Parent.Comments.Add(this.Node);
        }

        public CodeDomComment<P> ContinueComment(string text)
        {
            return new CodeDomComment<P>(text, this.Parent);
        }

        public CodeDomComment<P> ContinueComment(string text, bool docComment)
        {
            return new CodeDomComment<P>(text, docComment, this.Parent);
        }
    }
}