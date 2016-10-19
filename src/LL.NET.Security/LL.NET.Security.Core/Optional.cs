namespace LL.NET.Security.Core
{
    /// <summary>
    /// Generic class for enforcing validation on nullable objects in the anticorruption layer.
    /// Note: Do not use this in your domain objects. It is no more beneficial than an object that
    /// can be null once it's in your domain.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Optional<T>
    {
        public bool IsPresent { get; }
        public T Get { get; }
    }
}
