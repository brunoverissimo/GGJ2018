using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    [Header("Top  UI")]
    public Text coinsText;
    public Text powerText;
    public Text happinessText;
    public Text timeText;

    public Image powerProgress;
    public Image powerProgressMax;
    public Image cityNeedBar;

    [Header("Bottom  UI")]
    public GameObject ButtonGrid;
    public GameObject ButtonPrefab;



	// Use this for initialization
	void Start () {
        foreach ( EnergyProvider provider in GameManager.instance.energyProviders)
        {
            Debug.Log(provider.title);
            GameObject button = Instantiate(ButtonPrefab,ButtonGrid.transform);
            button.name = provider.title;
            ButtonPrefab.GetComponent<AddEnergyButton>().Setup(provider);
        }
    }

    private void SetCityNeed(float needs)
    {
        //powerProgressMax.GetComponent<RectTransform>().rect.width;
        RectTransform rt =  cityNeedBar.GetComponent<RectTransform>();

    }

    private void SetCoins(int coins)
    {
        coinsText.text = "$ " + coins;
    }


    private void SetCost(int power)
    {
        powerText.text = "$ " + power;
    }


    public void ToggleBuildButtons()
    {
        bool isActive = !ButtonGrid.active;
        ButtonGrid.SetActive(isActive);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
