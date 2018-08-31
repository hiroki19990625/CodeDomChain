using System.Linq;
using System.Reflection;

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

        public static T GetProperty<T>(object instance, string property)
        {
            PropertyInfo prop = instance.GetType().GetProperties().First(p => p.Name == property);
            if (prop != null)
            {
                return (T) prop.GetValue(instance);
            }

            return default(T);
        }

        public static void SetProperty<T>(object instance, string property, T value)
        {
            PropertyInfo prop = instance.GetType().GetProperties().First(p => p.Name == property);
            if (prop != null)
            {
                prop.SetValue(instance, value);
            }
        }
    }
}