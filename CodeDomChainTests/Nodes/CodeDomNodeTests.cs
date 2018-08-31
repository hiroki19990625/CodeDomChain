using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeDomChain.Nodes.Tests
{
    [TestClass()]
    public class CodeDomRootTests
    {
        [TestMethod()]
        public void CodeDomRootTest()
        {
            CodeDomRootUnit root = new CodeDomRootUnit();
            root.BeginAssembly(typeof(object).Assembly)//    <- Assembly: System (mscorlib)
            //    .ContinueAssembly(typeof(Button).Assembly)         <- Assembly: System.Windows.Forms
            .End()
            .BeginNamespace("")
                .BeginImport("System")
                .ContinueImport("System.Collections")
            .End()
            .ContinueNamespace("CodeDomChain.Test")
                .BeginType("Program")
                .End()
            .End();


        }
    }
}