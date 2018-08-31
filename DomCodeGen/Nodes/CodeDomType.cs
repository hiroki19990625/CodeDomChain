using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomType : CodeDomNodeBase<CodeTypeDeclaration, CodeDomNamespace>
    {
        public CodeDomType(string name, CodeDomNamespace parent) : base(parent)
        {
            this.Node = new CodeTypeDeclaration(name);
            parent.Node.Types.Add(this.Node);
        }
    }
}