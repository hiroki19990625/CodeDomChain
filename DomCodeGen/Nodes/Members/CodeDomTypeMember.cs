﻿using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public abstract class CodeDomTypeMember<N, P> : CodeDomNodeBase<N, P> where N : CodeTypeMember, new() where P : ICodeTypeMembers
    {
        public CodeDomTypeMember(P parent) : base(parent)
        {
            this.Node = new N();
            this.Parent.TypeMembers.Add(this.Node);
        }
    }
}