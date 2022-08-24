namespace PrototypeDesignPattern;

public class Person
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public Person ShallowCopy() =>
        (Person)MemberwiseClone();

    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = new string(Name);
        return clone;
    }
}
