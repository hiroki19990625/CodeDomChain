using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public abstract class CodeDomTypeDeclarationBase<N, P> : CodeDomNodeBase<N, P>, ICodeTypeDeclaration where N : CodeTypeDeclaration, new()
    {
        public CodeDomTypeDeclarationBase(string name, P parent) : base(parent)
        {
            this.Node = new N();
            this.Node.Name = name;
        }

        public CodeCommentStatementCollection Comments => this.Node.Comments;
        public CodeAttributeDeclarationCollection Attributes => this.Node.CustomAttributes;
        public CodeTypeParameterCollection TypeParameters => this.Node.TypeParameters;
        public CodeTypeReferenceCollection TypeReferences => this.Node.BaseTypes;
        public CodeTypeMemberCollection TypeMembers => this.Node.Members;
    }
}