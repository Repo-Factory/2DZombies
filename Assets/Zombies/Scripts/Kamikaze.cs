using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamikaze : Zombie
{
    // Start is called before the first frame update
    void Start()
    {
        this.health = 1f;
        this.speed = 6f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
