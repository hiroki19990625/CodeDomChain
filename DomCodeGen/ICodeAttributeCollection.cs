using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeAttributeCollection
    {
        CodeAttributeDeclarationCollection Attributes { get; }
    }
}