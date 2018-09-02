using System;
using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public class CodeDomMemberEvent<P> : CodeDomTypeMember<CodeMemberEvent, P>, ICodeTypeReference where P : ICodeTypeMemberCollection
    {
        public CodeDomMemberEvent(string name, P parent) : base(parent)
        {
            this.Node.Name = name;
        }

        public CodeDomMemberEvent(string name, Type type, P parent) : base(parent)
        {
            this.Node.Name = name;
            this.Node.Type = new CodeTypeReference(type);
        }

        public CodeDomMemberEvent(string name, string type, P parent) : base(parent)
        {
            this.Node.Name = name;
            this.Node.Type = new CodeTypeReference(type);
        }

        public CodeTypeReference TypeReference
        {
            get { return this.Node.Type; }
            set { this.Node.Type = value; }
        }

        public CodeDomMemberEvent<P> ContinueMemberEvent(string name)
        {
            return new CodeDomMemberEvent<P>(name, this.Parent);
        }

        public CodeDomMemberEvent<P> ContinueMemberEvent(string name, Type type)
        {
            return new CodeDomMemberEvent<P>(name, type, this.Parent);
        }

        public CodeDomMemberEvent<P> ContinueMemberEvent(string name, string type)
        {
            return new CodeDomMemberEvent<P>(name, type, this.Parent);
        }

        public CodeDomTypeReference<CodeDomMemberEvent<P>> BeginTypeReference(Type type)
        {
            return new CodeDomTypeReference<CodeDomMemberEvent<P>>(type, this);
        }

        public CodeDomTypeReference<CodeDomMemberEvent<P>> BeginTypeReference(string type)
        {
            return new CodeDomTypeReference<CodeDomMemberEvent<P>>(type, this);
        }
    }
}