﻿using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomStaticConstructor<P> : CodeDomMemberMethodBase<CodeTypeConstructor, P> where P : ICodeTypeMemberCollection
    {
        public CodeDomStaticConstructor(P parent) : base(parent)
        {
            this.Node.Name = "StaticConstructor";
        }
    }
}