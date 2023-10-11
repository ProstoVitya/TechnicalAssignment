namespace TechnicalAssignment;

public class Train
{
    public Wagon Head { get; private set; }
    public int Count { get; private set; }
    
    public Train(int wagonsCount)
    {
        var random = new Random(DateTime.Now.Millisecond);
        for (int i = 0; i < wagonsCount; i++)
        {
            var lightIsOn = random.NextDouble() > 0.5;
            AddWagon(lightIsOn);
        }
    }

    private void AddWagon(bool lightIsOn)
    {
        var wagon = new Wagon(lightIsOn);
        if (Head == null)
        {
            Head = wagon;
            Head.Next = wagon;
            Head.Previous = wagon;
        }
        else
        {
            wagon.Previous = Head;
            wagon.Next = Head.Next;
            Head.Next.Previous = wagon;
            Head.Next = wagon;
        }
        ++Count;
    }
}