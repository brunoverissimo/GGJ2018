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
        cost.text = energyProvider.cost.ToString();
        power.text = energyProvider.power.ToString();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
