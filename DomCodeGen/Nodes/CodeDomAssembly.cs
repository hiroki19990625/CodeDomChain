using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomAssembly : CodeDomNodeBase<string, CodeDomRoot>
    {
        public CodeDomAssembly(string assemblyName, CodeDomRoot parent) : base(parent)
        {
            this.Node = assemblyName;
            this.Parent.Unit.ReferencedAssemblies.Add(assemblyName);
        }

        public CodeDomAssembly(Assembly assembly, CodeDomRoot parent) : this(assembly.FullName, parent)
        {
        }

        public CodeDomAssembly Continue(string fullName)
        {
            return new CodeDomAssembly(fullName, this.Parent);
        }

        public CodeDomAssembly Continue(Assembly assembly)
        {
            return new CodeDomAssembly(assembly, this.Parent);
        }
    }
}