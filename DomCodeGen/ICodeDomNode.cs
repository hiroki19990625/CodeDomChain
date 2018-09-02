using System;

namespace CodeDomChain
{
    public interface ICodeDomNode<T, P>
    {
        T Node { get; }
        P Parent { get; }

        P End();
    }

    public static class NodeChain
    {
        public static T Chain<T>(this T source, Action<T> call)
        {
            if (source == null)
                return source;
            call(source);
            return source;
        }

        public static R Return<T, R>(this T source, Func<T, R> call)
        {
            if (source == null)
                return default(R);
            return call.Invoke(source);
        }
    }
}