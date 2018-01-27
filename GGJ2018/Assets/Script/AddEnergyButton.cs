using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddEnergyButton : MonoBehaviour {

    public Image icon;
    public Text title;
    public Text cost;
    public Text power;

    public void Setup(EnergyProvider energyProvider)
    {
        icon.sprite = energyProvider.iconSprite;
        title.text = energyProvider.title;
        SetCost(energyProvider.cost);
        SetPower(energyProvider.power);
    }

    private void SetCost(int costPrice)
    {
        cost.text = "$ " + costPrice;
    }

    private void SetPower(int energyPower)
    {
        power.text = energyPower + " MWZ";
    }

}
