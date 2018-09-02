using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;

namespace CodeDomChain.Nodes.Tests
{
    [TestClass()]
    public class CodeDomRootTests
    {
        [TestMethod()]
        public void CodeDomRootTest()
        {
            CodeDomRootUnit root = new CodeDomRootUnit();
            string cs = root.BeginAssembly(typeof(object).Assembly)//    <- Assembly: System (mscorlib)
            //    .ContinueAssembly(typeof(Button).Assembly)         <- Assembly: System.Windows.Forms
            .End()
            .BeginNamespace("")
                .BeginImport("System")
                .ContinueImport("System.Collections")
            .End()
            .ContinueNamespace("CodeDomChain.Test")
                .BeginTypeDeclaration("Program")
                    .Chain(x => x.BeginEntryPointMethod(x))
                .ContinueTypeDeclaration("User")
                    .Chain(x => x.BeginComment("TestUser", x))
                    .Chain(x => x.BeginMemberField("ID", typeof(long), x))
                    .Chain(x => x.BeginMemberField("Name", typeof(string), x))
                    .Return(x => x.BeginConstructor(x))
                        .Chain(x => x.SetMemberAttributesEnum(MemberAttributes.Public, x))
                        .Return(x => x.BeginComment("TestComment", x))
                    .End()
                .End()
                .Chain(x => x.BeginConstructor(x))
                .End()
                .BeginTypeDeclaration("SaveData")
                .End()
            .End().Compile();

            Console.WriteLine("==CS==");
            Console.WriteLine(cs);
            Console.WriteLine();

            try
            {
                Console.WriteLine("==VB==");
                Console.WriteLine(root.Compile(CompileLanguage.VB));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Console.WriteLine("==JS==");
                Console.WriteLine(root.Compile(CompileLanguage.JS));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Console.WriteLine("==CPP==");
                Console.WriteLine(root.Compile(CompileLanguage.CPP));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}