using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomAssemblies : CodeDomNodeBase<string, CodeDomRootUnit>
    {
        public CodeDomAssemblies(string assemblyName, CodeDomRootUnit parent) : base(parent)
        {
            this.Node = assemblyName;
            this.Parent.Unit.ReferencedAssemblies.Add(assemblyName);
        }

        public CodeDomAssemblies(Assembly assembly, CodeDomRootUnit parent) : this(assembly.FullName, parent)
        {
        }

        public CodeDomAssemblies ContinueAssembly(string fullName)
        {
            return new CodeDomAssemblies(fullName, this.Parent);
        }

        public CodeDomAssemblies ContinueAssembly(Assembly assembly)
        {
            return new CodeDomAssemblies(assembly, this.Parent);
        }
    }
}