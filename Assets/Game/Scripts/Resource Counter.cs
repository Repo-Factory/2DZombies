using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceCounter : MonoBehaviour
{
    public TextMeshProUGUI sunText;
    public TextMeshProUGUI bloodText;
    public TextMeshProUGUI boneText;
    private int sun = 100;
    private int blood = 50;
    private int bone = 50;

    void Update()
    {
        sunText.text = sun.ToString();
        bloodText.text = blood.ToString();
        boneText.text = bone.ToString();
    }

    public void addSun(int sun)
    {
        this.sun += sun;
    }
    public void addBlood(int blood)
    {
        this.blood += blood;
    }
    public void addBone(int bone)
    {
        this.bone += bone;
    }

    public void subtractCost(int sun, int blood, int bone)
    {
        this.sun -= sun;
        this.blood -= blood;
        this.bone -= bone;
    }

    public bool canAfford(int sun, int blood, int bone)
    {
        return this.sun >= sun && this.blood >= blood && this.bone >= bone;
    }

}
