public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
        }

        //Trying to use the context after it's been disposed will throw an exception.
        var data = context.MyTable.FirstOrDefault(); 
    }
}