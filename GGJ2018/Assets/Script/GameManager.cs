using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public List<EnergyProvider> energyProviders;

    public int coins;
    public int power;
    public int happiness;
   

    public float powerProgress;
    public float cityNeeds;

    float currentTime;
    public int secsToHour;
    public int time;
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
        secsToHour++;

    }
	
	// Update is called once per frame
	void Update () {
        TimeCounter();
    }

    void TimeCounter()
    {
        currentTime += Time.deltaTime;

        if (Mathf.RoundToInt(currentTime) % secsToHour == 0)
        {
            currentTime++;
            time++;
        }

        if(time >= 24)
        {
            time = 0;
        }
    }
}
