using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomNamespaces : CodeDomNodeBase<CodeNamespace, CodeDomRootUnit>, ICodeCommentCollection, ICodeTypeCollection
    {
        public CodeDomNamespaces(string name, CodeDomRootUnit parent) : base(parent)
        {
            this.Node = new CodeNamespace(name);
            parent.Unit.Namespaces.Add(this.Node);
        }

        public CodeTypeDeclarationCollection Types => this.Node.Types;
        public CodeCommentStatementCollection Comments => this.Node.Comments;

        public CodeDomNamespaces ContinueNamespace(string name)
        {
            return new CodeDomNamespaces(name, this.Parent);
        }

        public CodeDomImports BeginImport(string name)
        {
            return new CodeDomImports(name, this);
        }

        public CodeDomTypeDeclarations<CodeDomNamespaces> BeginTypeDeclaration(string name)
        {
            return new CodeDomTypeDeclarations<CodeDomNamespaces>(name, this);
        }

        public CodeDomComments<CodeDomNamespaces> BeginComment(string text)
        {
            return new CodeDomComments<CodeDomNamespaces>(text, this);
        }

        public CodeDomComments<CodeDomNamespaces> BeginComment(string text, bool docComment)
        {
            return new CodeDomComments<CodeDomNamespaces>(text, docComment, this);
        }
    }
}