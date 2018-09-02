using System;
using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public class CodeDomMemberField<P> : CodeDomTypeMember<CodeMemberField, P>, ICodeTypeReference where P : ICodeTypeMemberCollection
    {
        public CodeDomMemberField(string name, P parent) : base(parent)
        {
            this.Node.Name = name;
        }

        public CodeDomMemberField(string name, Type type, P parent) : base(parent)
        {
            this.Node.Name = name;
            this.Node.Type = new CodeTypeReference(type);
        }

        public CodeDomMemberField(string name, string type, P parent) : base(parent)
        {
            this.Node.Name = name;
            this.Node.Type = new CodeTypeReference(type);
        }

        public CodeTypeReference TypeReference
        {
            get { return this.Node.Type; }
            set { this.Node.Type = value; }
        }

        public CodeDomMemberField<P> ContinueMemberField(string name)
        {
            return new CodeDomMemberField<P>(name, this.Parent);
        }

        public CodeDomMemberField<P> ContinueMemberField(string name, Type type)
        {
            return new CodeDomMemberField<P>(name, type, this.Parent);
        }

        public CodeDomMemberField<P> ContinueMemberField(string name, string type)
        {
            return new CodeDomMemberField<P>(name, type, this.Parent);
        }

        public CodeDomTypeReference<CodeDomMemberField<P>> BeginTypeReference(Type type)
        {
            return new CodeDomTypeReference<CodeDomMemberField<P>>(type, this);
        }

        public CodeDomTypeReference<CodeDomMemberField<P>> BeginTypeReference(string type)
        {
            return new CodeDomTypeReference<CodeDomMemberField<P>>(type, this);
        }
    }
}