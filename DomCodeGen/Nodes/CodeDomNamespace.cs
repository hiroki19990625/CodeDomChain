using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomNamespace : CodeDomNodeBase<CodeNamespace, CodeDomRoot>
    {
        public CodeDomNamespace(string name, CodeDomRoot parent) : base(parent)
        {
            this.Node = new CodeNamespace(name);
            parent.Unit.Namespaces.Add(this.Node);
        }

        public CodeDomNamespace Continue(string name)
        {
            return new CodeDomNamespace(name, this.Parent);
        }

        public CodeDomImport BeginImport(string name)
        {
            return new CodeDomImport(name, this);
        }

        public CodeDomType BeginType(string name)
        {
            return new CodeDomType(name, this);
        }
    }
}