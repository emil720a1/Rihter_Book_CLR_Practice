namespace Rihter.Labs._06_PartialMethods;

// The 'partial' keyword allows us to split the class into two files
public partial class Exercise
{
    private string _name = string.Empty;
    
    // 1. Partial method declaration (No body allowed here)
    // If nobody implements this, the compiler will delete all calls to it
    partial void OnNameChanged(string newName);

    public string Name
    {
        get => _name;
        set
        {
            // 2. Call the partial hook
            OnNameChanged(value);
            _name = value;
        }
    }
}