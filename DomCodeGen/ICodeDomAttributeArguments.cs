using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeDomAttributeArguments
    {
        CodeAttributeArgumentCollection Arguments { get; }
    }
}