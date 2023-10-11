namespace TechnicalAssignment;

public class Watcher
{
    public int Count { get; private set; }
    public Wagon Current { get; private set; }
    
    public Watcher(Wagon currentWagon)
    {
        Current = currentWagon;
        Count = 0;
    }

    public void MoveNext()
    {
        Current = Current.Next;
        ++Count;
    }

    public void SwitchLight()
    {
        Current.SwitchLight();
    }

    public void Return()
    {
        while (Count > 0)
        {
            Current = Current.Previous;
            --Count;
        }
    }
}