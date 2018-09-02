using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeReference
    {
        CodeTypeReference TypeReference { get; set; }
    }
}