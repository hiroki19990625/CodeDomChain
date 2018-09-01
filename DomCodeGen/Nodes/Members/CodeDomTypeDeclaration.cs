using CodeDomChain.Nodes.Members.Methods;
using System;
using System.CodeDom;
using System.Reflection;

namespace CodeDomChain.Nodes.Members
{
    public class CodeDomTypeDeclaration<P> : CodeDomTypeDeclarationBase<CodeTypeDeclaration, P> where P : ICodeTypeMembers
    {
        public CodeDomTypeDeclaration(string name, P parent) : base(name, parent)
        {
            this.Node.Name = name;
            this.Parent.TypeMembers.Add(this.Node);
        }

        public CodeDomTypeDeclaration<P> ContinueTypeDeclaration(string name)
        {
            return new CodeDomTypeDeclaration<P>(name, this.Parent);
        }

        public CodeDomTypeDeclaration<P> IsClass(bool v)
        {
            this.Node.IsClass = v;
            return this;
        }

        public CodeDomTypeDeclaration<P> IsEnum(bool v)
        {
            this.Node.IsEnum = v;
            return this;
        }

        public CodeDomTypeDeclaration<P> IsInterface(bool v)
        {
            this.Node.IsInterface = v;
            return this;
        }

        public CodeDomTypeDeclaration<P> IsPartial(bool v)
        {
            this.Node.IsPartial = v;
            return this;
        }

        public CodeDomTypeDeclaration<P> IsStruct(bool v)
        {
            this.Node.IsStruct = v;
            return this;
        }

        public CodeDomTypeDeclaration<P> SetTypeAttributesEnum(TypeAttributes attributes)
        {
            this.Node.TypeAttributes = attributes;
            return this;
        }

        public CodeDomTypeDeclaration<P> SetMemberAttributesEnum(MemberAttributes attributes)
        {
            this.Node.Attributes = attributes;
            return this;
        }

        [Obsolete]
        public CodeDomTypeDeclaration<CodeDomTypeDeclaration<P>> BeginTypeDeclaration(string name)
        {
            return new CodeDomTypeDeclaration<CodeDomTypeDeclaration<P>>(name, this);
        }

        public CodeDomEntryPointMethod<CodeDomTypeDeclaration<P>> BeginEntryPointMethod()
        {
            return new CodeDomEntryPointMethod<CodeDomTypeDeclaration<P>>(this);
        }

        public CodeDomConstructor<CodeDomTypeDeclaration<P>> BeginConstructor()
        {
            return new CodeDomConstructor<CodeDomTypeDeclaration<P>>(this);
        }

        public CodeDomStaticConstructor<CodeDomTypeDeclaration<P>> BeginStaticConstructor()
        {
            return new CodeDomStaticConstructor<CodeDomTypeDeclaration<P>>(this);
        }

        public CodeDomMemberMethod<CodeDomTypeDeclaration<P>> BeginMemberMethod(string name)
        {
            return new CodeDomMemberMethod<CodeDomTypeDeclaration<P>>(name, this);
        }

        public CodeDomTypeParameter<CodeDomTypeDeclaration<P>> BeginTypeParameter(string name)
        {
            return new CodeDomTypeParameter<CodeDomTypeDeclaration<P>>(name, this);
        }

        public CodeDomTypeReference<CodeDomTypeDeclaration<P>> BeginBaseType(Type type)
        {
            return new CodeDomTypeReference<CodeDomTypeDeclaration<P>>(type, this);
        }

        public CodeDomComment<CodeDomTypeDeclaration<P>> BeginComment(string text)
        {
            return new CodeDomComment<CodeDomTypeDeclaration<P>>(text, this);
        }

        public CodeDomComment<CodeDomTypeDeclaration<P>> BeginComment(string text, bool docComment)
        {
            return new CodeDomComment<CodeDomTypeDeclaration<P>>(text, docComment, this);
        }

        public CodeDomAttribute<CodeDomTypeDeclaration<P>> BeginAttribute(string name)
        {
            return new CodeDomAttribute<CodeDomTypeDeclaration<P>>(name, this);
        }
    }
}