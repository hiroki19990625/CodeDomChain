using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;

namespace CodeDomChainTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CompilerInfo[] infos = CodeDomProvider.GetAllCompilerInfo();
            foreach (CompilerInfo info in infos)
            {
                string[] strs = info.GetLanguages();
                foreach (string str in strs)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
