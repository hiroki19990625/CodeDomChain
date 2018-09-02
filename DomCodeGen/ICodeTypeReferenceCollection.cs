using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeReferenceCollection
    {
        CodeTypeReferenceCollection TypeReferences { get; }
    }
}