
// RegularFish inherits from Fish
public class RegularFish : Fish
{
    public override void destroyFish()
    {
        // Implementation to destroy the regular fish
        Destroy(gameObject);
    }
}