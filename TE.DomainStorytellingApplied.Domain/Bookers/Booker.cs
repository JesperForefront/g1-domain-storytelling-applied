namespace TE.DomainStorytellingApplied.Domain.Bookers;

public class Booker
{
    public Guid Id { get; private init; }
    public string FirstName { get; private init; }
    public string LastName { get; private init; }
    public string PhoneNumber { get; private init; }
    public string Email { get; private init; }
    public IBookerType Type { get; private init; }

    public Booker(string firstName, string lastName, string phoneNumber, string email, IBookerType type)
    {
        EnsureNotEmpty(firstName, nameof(firstName));
        EnsureNotEmpty(lastName, nameof(lastName));
        EnsureNotEmpty(phoneNumber, nameof(phoneNumber));
        EnsureNotEmpty(email, nameof(email));
        ArgumentNullException.ThrowIfNull(type);

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Type = type;
    }

    private static void EnsureNotEmpty(string value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{paramName} cannot be empty.", paramName);
        }
    }
}
