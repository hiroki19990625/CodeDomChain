using System.CodeDom;

namespace CodeDomChain.Nodes.Members.Methods
{
    public class CodeDomMemberMethod<P> : CodeDomMemberMethodBase<CodeMemberMethod, P> where P : ICodeTypeMemberCollection
    {
        public CodeDomMemberMethod(string name, P parent) : base(parent)
        {
            this.Node.Name = name;
        }
    }
}