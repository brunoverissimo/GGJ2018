using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnergyType
{
    COAL,
    OIL,
    SOLAR,
    THERMAL,
    NUCLEAR

}

[Serializable]
public class EnergyProvider  {

    public Sprite iconSprite;
    public Sprite hexSprite;

    public string title;

    public int cost;
    public int power;
    public int maintence;


    public EnergyType energyType;

    //@TODO change from object to correct type
    public GameObject hexRequirement;
}
