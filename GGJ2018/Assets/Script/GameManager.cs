using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public List<EnergyProvider> energyProviders;

    public int coins;
    public int power;
    public int happiness;
    public int time;
    public string timeLabel;

    public float powerProgress;
    public float cityNeeds;

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
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
