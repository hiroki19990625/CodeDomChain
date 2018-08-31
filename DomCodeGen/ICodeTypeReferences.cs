using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeReferences
    {
        CodeTypeReferenceCollection TypeReferences { get; }
    }
}