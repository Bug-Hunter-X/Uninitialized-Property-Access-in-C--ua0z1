public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        // Now accessing MyProperty is safe, as it will always have a value.
        int value = MyProperty;
    }

    //Alternatively, use null checks or default values to avoid potential issues:
    public void MyOtherMethod()
    {
        int? nullableProperty = MyProperty;
        int safeValue = nullableProperty ?? 0; // Null-coalescing operator: use 0 if nullableProperty is null
    }
}