using CodeDomChain.Nodes.Members.Methods;
using System;
using System.CodeDom;
using System.Reflection;

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

        public T IsClass<T>(bool v, T parent)
        {
            this.Node.IsClass = v;
            return parent;
        }

        public T IsEnum<T>(bool v, T parent)
        {
            this.Node.IsEnum = v;
            return parent;
        }

        public T IsInterface<T>(bool v, T parent)
        {
            this.Node.IsInterface = v;
            return parent;
        }

        public T IsPartial<T>(bool v, T parent)
        {
            this.Node.IsPartial = v;
            return parent;
        }

        public T IsStruct<T>(bool v, T parent)
        {
            this.Node.IsStruct = v;
            return parent;
        }

        public T SetTypeAttributesEnum<T>(TypeAttributes attributes, T parent)
        {
            this.Node.TypeAttributes = attributes;
            return parent;
        }

        public T SetMemberAttributesEnum<T>(MemberAttributes attributes, T parent)
        {
            this.Node.Attributes = attributes;
            return parent;
        }

        public CodeDomMemberEvent<T> BeginMemberEvent<T>(string name, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberEvent<T>(name, parent);
        }

        public CodeDomMemberEvent<T> BeginMemberEvent<T>(string name, Type type, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberEvent<T>(name, type, parent);
        }

        public CodeDomMemberEvent<T> BeginMemberEvent<T>(string name, string type, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberEvent<T>(name, type, parent);
        }

        public CodeDomMemberField<T> BeginMemberField<T>(string name, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberField<T>(name, parent);
        }

        public CodeDomMemberField<T> BeginMemberField<T>(string name, Type type, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberField<T>(name, type, parent);
        }

        public CodeDomMemberProperty<T> BeginMemberProperty<T>(string name, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberProperty<T>(name, parent);
        }

        public CodeDomMemberProperty<T> BeginMemberProperty<T>(string name, Type type, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberProperty<T>(name, type, parent);
        }

        public CodeDomMemberProperty<T> BeginMemberProperty<T>(string name, string type, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberProperty<T>(name, type, parent);
        }

        public CodeDomSnippetTypeMember<T> BeginSnippetTypeMember<T>(string text, T parent)
            where T : ICodeTypeMemberCollection
        {
            return new CodeDomSnippetTypeMember<T>(text, parent);
        }

        public CodeDomTypeDeclaration<T> BeginTypeDeclaration<T>(string name, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomTypeDeclaration<T>(name, parent);
        }

        public CodeDomEntryPointMethod<T> BeginEntryPointMethod<T>(T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomEntryPointMethod<T>(parent);
        }

        public CodeDomConstructor<T> BeginConstructor<T>(T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomConstructor<T>(parent);
        }

        public CodeDomStaticConstructor<T> BeginStaticConstructor<T>(T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomStaticConstructor<T>(parent);
        }

        public CodeDomMemberMethod<T> BeginMemberMethod<T>(string name, T parent) where T : ICodeTypeMemberCollection
        {
            return new CodeDomMemberMethod<T>(name, parent);
        }

        public CodeDomTypeParameters<T> BeginTypeParameter<T>(string name, T parent) where T : ICodeTypeParameterCollection
        {
            return new CodeDomTypeParameters<T>(name, parent);
        }

        public CodeDomTypeReferences<T> BeginBaseType<T>(Type type, T parent) where T : ICodeTypeReferenceCollection
        {
            return new CodeDomTypeReferences<T>(type, parent);
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