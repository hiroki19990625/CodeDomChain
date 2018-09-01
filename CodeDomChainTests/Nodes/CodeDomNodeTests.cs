using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                .BeginType("Program")

                .End()
            .End().Compile();

            Console.WriteLine("==CS==");
            Console.WriteLine(cs);
            Console.WriteLine();
            Console.WriteLine("==VB==");
            Console.WriteLine(root.Compile(CompileLanguage.VB));
            Console.WriteLine();
            Console.WriteLine("==JS==");
            Console.WriteLine(root.Compile(CompileLanguage.JS));
            Console.WriteLine();
            Console.WriteLine("==CPP==");
            Console.WriteLine(root.Compile(CompileLanguage.CPP));
        }
    }
}