using System.CodeDom;

namespace CodeDomChain
{
    public interface ICodeAttributes
    {
        CodeAttributeDeclarationCollection Attributes { get; }
    }
}