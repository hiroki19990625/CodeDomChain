namespace CodeDomChain
{
    public interface ICodeDomNode<T, P>
    {
        T Node { get; }
        P Parent { get; }

        P End();
    }
}