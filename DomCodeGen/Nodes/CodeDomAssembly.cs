using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomAssembly : CodeDomNodeBase<string, CodeDomRootUnit>
    {
        public CodeDomAssembly(string assemblyName, CodeDomRootUnit parent) : base(parent)
        {
            this.Node = assemblyName;
            this.Parent.Unit.ReferencedAssemblies.Add(assemblyName);
        }

        public CodeDomAssembly(Assembly assembly, CodeDomRootUnit parent) : this(assembly.FullName, parent)
        {
        }

        public CodeDomAssembly ContinueAssembly(string fullName)
        {
            return new CodeDomAssembly(fullName, this.Parent);
        }

        public CodeDomAssembly ContinueAssembly(Assembly assembly)
        {
            return new CodeDomAssembly(assembly, this.Parent);
        }
    }
}