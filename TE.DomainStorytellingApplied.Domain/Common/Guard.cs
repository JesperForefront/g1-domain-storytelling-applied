using System.Runtime.CompilerServices;

namespace TE.DomainStorytellingApplied.Domain.Common;

internal static class Guard
{
    public static void EnsureNotEmpty(string value, [CallerArgumentExpression(nameof(value))] string? paramName = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{paramName} cannot be empty or null.", paramName);
        }
    }
}
