using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour {

    public GameObject ButtonGrid;
    public GameObject ButtonPrefab;

	// Use this for initialization
	void Start () {

        foreach( EnergyProvider provider in GameManager.instance.energyProviders)
        {
            GameObject button = Instantiate(ButtonPrefab,ButtonGrid.transform);
            ButtonPrefab.GetComponent<AddEnergyButton>().Setup(provider);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
