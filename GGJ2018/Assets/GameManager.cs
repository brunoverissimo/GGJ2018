using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public List<EnergyProvider> energyProviders;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        energyProviders = new List<EnergyProvider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
