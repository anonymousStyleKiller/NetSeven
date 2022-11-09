namespace LINQNetSeven;

public class PersonModel : IComparable<PersonModel>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(PersonModel? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return Age.CompareTo(other.Age);
    }
}