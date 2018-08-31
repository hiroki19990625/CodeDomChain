using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomNamespace : CodeDomNodeBase<CodeNamespace, CodeDomRootUnit>, ICodeComments
    {
        public CodeDomNamespace(string name, CodeDomRootUnit parent) : base(parent)
        {
            this.Node = new CodeNamespace(name);
            parent.Unit.Namespaces.Add(this.Node);
        }

        public CodeCommentStatementCollection Comments => this.Node.Comments;

        public CodeDomNamespace ContinueNamespace(string name)
        {
            return new CodeDomNamespace(name, this.Parent);
        }

        public CodeDomImport BeginImport(string name)
        {
            return new CodeDomImport(name, this);
        }

        public CodeDomType BeginType(string name)
        {
            return new CodeDomType(name, this);
        }

        public CodeDomComment<CodeDomNamespace> BeginComment(string text)
        {
            return new CodeDomComment<CodeDomNamespace>(text, this);
        }

        public CodeDomComment<CodeDomNamespace> BeginComment(string text, bool docComment)
        {
            return new CodeDomComment<CodeDomNamespace>(text, docComment, this);
        }
    }
}