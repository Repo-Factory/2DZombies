using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    public GameObject resourceCounterContainer;
    public ResourceCounter resourceCounter;
    public float addSunInterval = 2;

    void Start()
    {
        resourceCounter = resourceCounterContainer.GetComponent<ResourceCounter>();
    }

    void Update()
    {
        InvokeRepeating("addSun", 2f, addSunInterval);
    }

    public void addSun()
    {
        resourceCounter.addSun(25);
    }
}
