public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object - fixed
        using (var context = new MyDbContext())
        {
            //Retrieve data before disposing the context
            var data = context.MyTable.FirstOrDefault();
            // ... some code that uses the context ...
        }

        //Now it's safe to use the data
        //Use the data variable here
    }
}