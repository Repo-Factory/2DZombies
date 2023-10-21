using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    public ResourceCounter resourceCounter;
    public float addSunInterval = 2f;

    public void Start()
    {
        resourceCounter = GameObject.Find("ResourceCounter").GetComponent<ResourceCounter>();
        InvokeRepeating("AddSun", 1f, addSunInterval);
    }

    public void AddSun()
    {
        resourceCounter.addSun(10);
    }
}
