using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomEntryPointMethod<P> : CodeDomMemberMethodBase<CodeEntryPointMethod, P> where P : ICodeTypeMemberCollection
    {
        public CodeDomEntryPointMethod(P parent) : base(parent)
        {
            this.Node.Name = "EntryPoint";
        }
    }
}