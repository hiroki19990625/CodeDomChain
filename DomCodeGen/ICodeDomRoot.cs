using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeDomRoot
    {
        CodeCompileUnit Unit { get; }
    }
}