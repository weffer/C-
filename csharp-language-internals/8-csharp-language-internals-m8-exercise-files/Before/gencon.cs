public class Bar<T> where T : new()
{
  public void Foo()
  {
    T item = new T();
  }
}