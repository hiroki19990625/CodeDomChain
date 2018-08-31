using System.CodeDom;
using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomRootUnit : ICodeDomRoot, ICodeAttributes
    {
        public CodeCompileUnit Unit { get; }

        public CodeDomRootUnit()
        {
            this.Unit = new CodeCompileUnit();
        }

        public CodeAttributeDeclarationCollection Attributes => this.Unit.AssemblyCustomAttributes;

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

        public CodeDomAttribute<CodeDomRootUnit> BeginAttribute(string name)
        {
            return new CodeDomAttribute<CodeDomRootUnit>(name, this);
        }
    }
}