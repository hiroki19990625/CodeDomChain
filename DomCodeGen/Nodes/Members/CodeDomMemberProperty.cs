using System;
using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public class CodeDomMemberProperty<P> : CodeDomTypeMember<CodeMemberProperty, P>, ICodeTypeReference where P : ICodeTypeMemberCollection
    {
        public CodeDomMemberProperty(string name, P parent) : base(parent)
        {
            this.Node.Name = name;
        }

        public CodeDomMemberProperty(string name, Type type, P parent) : base(parent)
        {
            this.Node.Name = name;
            this.Node.Type = new CodeTypeReference(type);
        }

        public CodeDomMemberProperty(string name, string type, P parent) : base(parent)
        {
            this.Node.Name = name;
            this.Node.Type = new CodeTypeReference(type);
        }

        public CodeTypeReference TypeReference
        {
            get { return this.Node.Type; }
            set { this.Node.Type = value; }
        }

        public CodeDomMemberProperty<P> ContinueMemberProperty(string name)
        {
            return new CodeDomMemberProperty<P>(name, this.Parent);
        }

        public CodeDomMemberProperty<P> ContinueMemberProperty(string name, Type type)
        {
            return new CodeDomMemberProperty<P>(name, type, this.Parent);
        }

        public CodeDomMemberProperty<P> ContinueMemberProperty(string name, string type)
        {
            return new CodeDomMemberProperty<P>(name, type, this.Parent);
        }

        public CodeDomMemberProperty<P> HasGet(bool val)
        {
            this.Node.HasGet = val;
            return this;
        }

        public CodeDomMemberProperty<P> HasSet(bool val)
        {
            this.Node.HasSet = val;
            return this;
        }

        public CodeDomTypeReference<CodeDomMemberProperty<P>> BeginTypeReference(Type type)
        {
            return new CodeDomTypeReference<CodeDomMemberProperty<P>>(type, this);
        }

        public CodeDomTypeReference<CodeDomMemberProperty<P>> BeginTypeReference(string type)
        {
            return new CodeDomTypeReference<CodeDomMemberProperty<P>>(type, this);
        }
    }
}