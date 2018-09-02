using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public abstract class CodeDomTypeMember<N, P> : CodeDomNodeBase<N, P>, ICodeAttributeCollection, ICodeCommentCollection where N : CodeTypeMember, new() where P : ICodeTypeMemberCollection
    {
        public CodeDomTypeMember(P parent) : base(parent)
        {
            this.Node = new N();
            this.Parent.TypeMembers.Add(this.Node);
        }

        public CodeAttributeDeclarationCollection Attributes => this.Node.CustomAttributes;
        public CodeCommentStatementCollection Comments => this.Node.Comments;

        public T SetMemberAttributesEnum<T>(MemberAttributes attributes, T parent)
        {
            this.Node.Attributes = attributes;
            return parent;
        }

        public CodeDomComments<T> BeginComment<T>(string text, T parent) where T : ICodeCommentCollection
        {
            return new CodeDomComments<T>(text, parent);
        }

        public CodeDomComments<T> BeginComment<T>(string text, bool docComment, T parent) where T : ICodeCommentCollection
        {
            return new CodeDomComments<T>(text, docComment, parent);
        }

        public CodeDomAttributes<T> BeginAttribute<T>(string name, T parent) where T : ICodeAttributeCollection
        {
            return new CodeDomAttributes<T>(name, parent);
        }
    }
}
