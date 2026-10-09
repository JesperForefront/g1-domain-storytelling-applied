namespace TE.DomainStorytellingApplied.Domain.Premises;

public class Premise
{
    public Guid Id { get; private init; }
    public string Name { get; private init; }

    public Premise(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A premise must have a name.", nameof(name));
        }

        Id = Guid.NewGuid();
        Name = name;
    }
}
