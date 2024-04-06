using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ExplodingFish inherits from AnimatedFish
public class ExplodingFish : AnimatedFish
{
    
    public override void destroyFish()
    {
        // Implementation to destroy the exploding fish, possibly with some animation
        Destroy(gameObject);

    }
}