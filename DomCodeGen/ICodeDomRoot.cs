using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeDomRoot : ICodeAttributes
    {
        CodeCompileUnit Unit { get; }
    }
}