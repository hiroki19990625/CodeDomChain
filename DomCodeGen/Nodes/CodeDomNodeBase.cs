namespace CodeDomChain.Nodes
{
    public abstract class CodeDomNodeBase<N, P> : ICodeDomNode<N, P>
    {
        public N Node { get; protected set; }
        public P Parent { get; protected set; }

        public CodeDomNodeBase(P parent)
        {
            this.Parent = parent;
        }

        public virtual P End()
        {
            return this.Parent;
        }
    }
}