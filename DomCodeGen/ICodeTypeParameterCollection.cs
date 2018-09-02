using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeParameterCollection
    {
        CodeTypeParameterCollection TypeParameters { get; }
    }
}