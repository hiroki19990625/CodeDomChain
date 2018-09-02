using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeTypeCollection
    {
        CodeTypeDeclarationCollection Types { get; }
    }
}
