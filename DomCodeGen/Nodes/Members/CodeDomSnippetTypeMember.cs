using System.CodeDom;

namespace CodeDomChain.Nodes.Members
{
    public class CodeDomSnippetTypeMember<P> : CodeDomTypeMember<CodeSnippetTypeMember, P> where P : ICodeTypeMemberCollection
    {
        public CodeDomSnippetTypeMember(string text, P parent) : base(parent)
        {
            this.Node.Text = text;
        }
    }
}
