namespace LL.NET.Security.Core
{
    /// <summary>
    /// This is container that prevents the value inside from being accessed unless
    /// it has been validated. The following line makes the <see cref="Value"/>
    /// parameter accessible from the Validation libary.
    /// [assembly: InternalIsVisibleTo("Validation")]
    /// This forces developers to ensure their data has been validated by only
    /// allowing access through validators.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Untrusted<T>
    {
        readonly T _value;

        public Untrusted(T value)
        {
            _value = value;
        }

        private T Value
        {
            get { return _value; }
        }
    }
}
