namespace TE.DomainStorytellingApplied.Domain;

public class Timeslot
{
    public Guid Id { get; private init; }
    public Guid PremisesId { get; private init; }
    public DateTime StartTime { get; private init; }
    public DateTime EndTime { get; private init; }

    public Timeslot(Guid premisesId, DateTime startTime, DateTime endTime)
    {
        if (endTime <= startTime)
        {
            throw new ArgumentException("A timeslot must end after it starts.", nameof(endTime));
        }

        Id = Guid.NewGuid();
        PremisesId = premisesId;
        StartTime = startTime;
        EndTime = endTime;
    }
}
