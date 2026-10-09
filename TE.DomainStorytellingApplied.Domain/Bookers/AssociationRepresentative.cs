namespace TE.DomainStorytellingApplied.Domain.Bookers;

public sealed class AssociationRepresentative : IBookerType
{
    public string OrganizationName { get; private init; }

    public AssociationRepresentative(string organizationName)
    {
        if (string.IsNullOrWhiteSpace(organizationName))
        {
            throw new ArgumentException("An association representative must represent an organization.", nameof(organizationName));
        }

        OrganizationName = organizationName;
    }
}
