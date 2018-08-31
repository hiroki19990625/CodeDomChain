using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeDomChain.Nodes.Tests
{
    [TestClass()]
    public class CodeDomRootTests
    {
        [TestMethod()]
        public void CodeDomRootTest()
        {
            CodeDomRoot root = new CodeDomRoot();
            root.BeginAssembly(typeof(object).Assembly)//    <- Assembly: System (mscorlib)
            //    .Continue(typeof(Button).Assembly)         <- Assembly: System.Windows.Forms
            .End()
            .BeginNamespace("")
                .BeginImport("System")
                .Continue("System.Collections")
            .End()
            .Continue("CodeDomChain.Test")
                .BeginType("Program")
                .End()
            .End();


        }
    }
}