using System.CodeDom;

namespace CodeDomChain.Nodes
{
    public class CodeDomImports : CodeDomNodeBase<CodeNamespaceImport, CodeDomNamespaces>
    {
        public CodeDomImports(string name, CodeDomNamespaces parent) : base(parent)
        {
            this.Node = new CodeNamespaceImport(name);
            this.Parent.Node.Imports.Add(this.Node);
        }

        public CodeDomImports ContinueImport(string name)
        {
            return new CodeDomImports(name, this.Parent);
        }
    }
}