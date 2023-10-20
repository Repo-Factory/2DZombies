using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : Zombie
{
    // Start is called before the first frame update
    void Start()
    {
        this.health = 20f;
        this.speed = 1f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
