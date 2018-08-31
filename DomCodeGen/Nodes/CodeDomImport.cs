using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomImport : CodeDomNodeBase<CodeNamespaceImport, CodeDomNamespace>
    {
        public CodeDomImport(string name, CodeDomNamespace parent) : base(parent)
        {
            this.Node = new CodeNamespaceImport(name);
            this.Parent.Node.Imports.Add(this.Node);
        }

        public CodeDomImport ContinueImport(string name)
        {
            return new CodeDomImport(name, this.Parent);
        }
    }
}