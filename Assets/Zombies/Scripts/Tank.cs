using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Zombie
{
    // Start is called before the first frame update
    void Start()
    {
        this.health = 100f;
        this.speed = .2f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
