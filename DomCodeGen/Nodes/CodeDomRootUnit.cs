using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;

namespace CodeDomChain.Nodes
{
    public class CodeDomRootUnit : ICodeDomRoot
    {
        public CodeCompileUnit Unit { get; }

        public CodeDomRootUnit()
        {
            this.Unit = new CodeCompileUnit();
        }

        public CodeAttributeDeclarationCollection Attributes => this.Unit.AssemblyCustomAttributes;

        public CodeDomNamespaces BeginNamespace(string name)
        {
            return new CodeDomNamespaces(name, this);
        }

        public CodeDomAssemblies BeginAssembly(string fullName)
        {
            return new CodeDomAssemblies(fullName, this);
        }

        public CodeDomAssemblies BeginAssembly(Assembly assembly)
        {
            return new CodeDomAssemblies(assembly, this);
        }

        public CodeDomAttributes<CodeDomRootUnit> BeginAttribute(string name)
        {
            return new CodeDomAttributes<CodeDomRootUnit>(name, this);
        }

        public string Compile()
        {
            return this.Compile(CompileLanguage.CS);
        }

        public string Compile(CompileLanguage language)
        {
            return this.Compile(language.ToString());
        }

        public string Compile(string language)
        {
            CodeGeneratorOptions options = new CodeGeneratorOptions()
            {
                BracingStyle = "C",
                IndentString = "    ",
                BlankLinesBetweenMembers = false
            };

            return this.Compile(language, options);
        }

        public string Compile(CodeGeneratorOptions options)
        {
            return this.Compile(CompileLanguage.CS, options);
        }

        public string Compile(CompileLanguage language, CodeGeneratorOptions options)
        {
            return this.Compile(language.ToString(), options);
        }

        public string Compile(string language, CodeGeneratorOptions options)
        {
            using (StringWriter writer = new StringWriter())
            {
                CodeDomProvider.CreateProvider(language).GenerateCodeFromCompileUnit(this.Unit, writer, options);

                return writer.ToString();
            }
        }
    }
}