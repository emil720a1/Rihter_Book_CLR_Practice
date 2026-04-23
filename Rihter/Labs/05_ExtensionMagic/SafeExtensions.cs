namespace Rihter.Labs._05_ExtensionMagic;

public static class SafeExtensions
{
    // Null check for any object
    // This method won't throw NullReferenceException even if called on a null reference
    public static bool IsNull(this object? obj)
    {
        return obj == null;
    }
    
    // Extension method for IEnumerable interface
    // Works for List, Array, Stack, and other collections types
    public static void PrintAll<T>(this IEnumerable<T>? collection)
    {
        if (collection == null)
        {
            Console.WriteLine("LOG: Collection is null, nothing to display");
            return;
        }
        
        foreach (var item in collection)
        {
            Console.WriteLine($"Item: {item}");
        }
    }
}