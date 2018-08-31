using System.CodeDom;
using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomRoot : ICodeDomRoot
    {
        public CodeCompileUnit Unit { get; }

        public CodeDomRoot()
        {
            this.Unit = new CodeCompileUnit();
        }

        public CodeDomNamespace BeginNamespace(string name)
        {
            return new CodeDomNamespace(name, this);
        }

        public CodeDomAssembly BeginAssembly(string fullName)
        {
            return new CodeDomAssembly(fullName, this);
        }

        public CodeDomAssembly BeginAssembly(Assembly assembly)
        {
            return new CodeDomAssembly(assembly, this);
        }
    }
}