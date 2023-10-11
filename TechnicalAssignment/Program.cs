using TechnicalAssignment;

var random = new Random(DateTime.Now.Millisecond);
var wagonsCount = random.Next(2, 11);
var train = new Train(wagonsCount);

Console.WriteLine("Expected count: " + train.Count);

var watcher = new Watcher(train.Head);
if (!watcher.Current.LightIsOn)
{
    watcher.SwitchLight();
}

int count;
do
{
    do
    {
        watcher.MoveNext();
    } while (!watcher.Current.LightIsOn);
    watcher.SwitchLight();
    count = watcher.Count;
    watcher.Return();
} while (watcher.Current.LightIsOn);

Console.WriteLine("Actual count: " + count);