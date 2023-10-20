using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chump : Zombie
{
    // Start is called before the first frame update
    void Start()
    {
        this.health = 6.0f;
        this.speed =  0.5f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
