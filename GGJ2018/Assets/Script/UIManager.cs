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

    private float totalNeed = 100;

    [Header("Bottom  UI")]
    public GameObject ButtonGrid;
    public GameObject ButtonPrefab;



	// Use this for initialization
	void Start () {
        foreach ( EnergyProvider provider in GameManager.instance.energyProviders)
        {
            GameObject button = Instantiate(ButtonPrefab,ButtonGrid.transform);
            button.name = provider.title;
            button.GetComponent<AddEnergyButton>().Setup(provider);
        }
    }

   

    // Update is called once per frame
    void Update () {
        UpdateHeaderValues();
    }

    string HourToClockHour(int hour)
    {
        string result = "";
        if(hour < 12)
        {
            result = hour  + " AM";

        }
        else if (hour == 12)
        {
            result = hour + " PM";
        }
        else
        {
            result = (hour - 12) + " PM";
        }

        return result;
    }

    void UpdateHeaderValues()
    {
        SetProgressBar(GameManager.instance.cityNeeds, GameManager.instance.powerProgress);
        SetCoins(GameManager.instance.coins);
        SetPower(GameManager.instance.power);
        SetHappiness(GameManager.instance.happiness);
        SetTime(HourToClockHour(GameManager.instance.time));
    }


    private void SetProgressBar(float needs, float power)
    {
        //powerProgressMax.GetComponent<RectTransform>().rect.width;

        if (needs > power)
        {
            totalNeed = needs;
        }
        else
        {
            totalNeed = power;
        }

        float needsPosition = (needs / totalNeed) * powerProgressMax.rectTransform.rect.width;
        float powerWidth = (power / totalNeed) * powerProgressMax.rectTransform.rect.width;

        cityNeedBar.GetComponent<RectTransform>().localPosition = new Vector3(needsPosition, 0);
        powerProgress.GetComponent<RectTransform>().sizeDelta = new Vector2(powerWidth, powerProgress.rectTransform.rect.height);

    }

    private void SetCoins(int coins)
    {
        coinsText.text = "$ " + coins;
    }
    private void SetPower(int power)
    {
        powerText.text = power + " MHZ";
    }
    private void SetHappiness(float happiness)
    {
        happinessText.text = happiness + "%";
    }
    private void SetTime(string time)
    {
        timeText.text = time;
    }

    public void ToggleBuildButtons()
    {
        bool isActive = !ButtonGrid.active;
        ButtonGrid.SetActive(isActive);
    }
}
