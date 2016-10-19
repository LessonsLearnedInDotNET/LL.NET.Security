namespace LL.NET.Security.Core
{
    //Generic class for enforcing validation on nullable objects.
    public class Optional<T>
    {
        public bool IsPresent { get; }
        public T Get { get; }
    }
}
