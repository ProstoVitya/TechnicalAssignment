namespace TechnicalAssignment;

public class Wagon
{
   public Wagon Next { get; set; }
   public Wagon Previous { get; set; }
   public bool LightIsOn { get; private set; }

    public Wagon(bool lightIsOn) => LightIsOn = lightIsOn;

    public void SwitchLight()
    {
        LightIsOn = !LightIsOn;
    }
}