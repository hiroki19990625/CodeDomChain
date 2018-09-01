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