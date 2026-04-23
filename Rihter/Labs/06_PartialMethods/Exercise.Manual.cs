namespace Rihter.Labs._06_PartialMethods;

public partial class Exercise
{
    partial void OnNameChanged(string newName)
    {
        if (string.IsNullOrEmpty(newName))
        {
            throw new ArgumentException("Exersice name cannot be empty", nameof(newName));
        }
        Console.WriteLine($"LOG: Chsnging exercise name to '{newName}'...");
    }
}