using System;
using System.CodeDom;
using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomType : CodeDomNodeBase<CodeTypeDeclaration, CodeDomNamespace>, ICodeComments, ICodeAttributes, ICodeTypeParameters, ICodeTypeReferences, ICodeTypeMembers
    {
        public CodeDomType(string name, CodeDomNamespace parent) : base(parent)
        {
            this.Node = new CodeTypeDeclaration(name);
            parent.Node.Types.Add(this.Node);
        }

        public CodeCommentStatementCollection Comments => this.Node.Comments;
        public CodeAttributeDeclarationCollection Attributes => this.Node.CustomAttributes;
        public CodeTypeParameterCollection TypeParameters => this.Node.TypeParameters;
        public CodeTypeReferenceCollection TypeReferences => this.Node.BaseTypes;
        public CodeTypeMemberCollection TypeMembers => this.Node.Members;

        public CodeDomType IsClass(bool v)
        {
            this.Node.IsClass = v;
            return this;
        }

        public CodeDomType IsEnum(bool v)
        {
            this.Node.IsEnum = v;
            return this;
        }

        public CodeDomType IsInterface(bool v)
        {
            this.Node.IsInterface = v;
            return this;
        }

        public CodeDomType IsPartial(bool v)
        {
            this.Node.IsPartial = v;
            return this;
        }

        public CodeDomType IsStruct(bool v)
        {
            this.Node.IsStruct = v;
            return this;
        }

        public CodeDomType SetTypeAttributesEnum(TypeAttributes attributes)
        {
            this.Node.TypeAttributes = attributes;
            return this;
        }

        public CodeDomType SetMemberAttributesEnum(MemberAttributes attributes)
        {
            this.Node.Attributes = attributes;
            return this;
        }

        public CodeDomType ContinueType(string name)
        {
            return new CodeDomType(name, this.Parent);
        }

        //TODO TypeMenber...

        public CodeDomTypeParameter<CodeDomType> BeginTypeParameter(string name)
        {
            return new CodeDomTypeParameter<CodeDomType>(name, this);
        }

        public CodeDomTypeReference<CodeDomType> BeginBaseType(Type type)
        {
            return new CodeDomTypeReference<CodeDomType>(type, this);
        }

        public CodeDomComment<CodeDomType> BeginComment(string text)
        {
            return new CodeDomComment<CodeDomType>(text, this);
        }

        public CodeDomComment<CodeDomType> BeginComment(string text, bool docComment)
        {
            return new CodeDomComment<CodeDomType>(text, docComment, this);
        }

        public CodeDomAttribute<CodeDomType> BeginAttribute(string name)
        {
            return new CodeDomAttribute<CodeDomType>(name, this);
        }
    }
}