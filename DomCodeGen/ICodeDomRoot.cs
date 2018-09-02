using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeDomRoot : ICodeAttributeCollection
    {
        CodeCompileUnit Unit { get; }
    }
}