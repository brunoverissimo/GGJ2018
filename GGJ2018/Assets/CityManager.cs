using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour {

    [System.Serializable]
    public class CityTile {

        public Sprite srpite;
        //public TextAsset json;

    }

    public Map map;


    public List<CityTile> citySprites;

     

	// Use this for initialization
	void Start () {

        AddNewCityTile();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddNewCityTile() {

        GameObject tile = map.GetTile();

        tile.GetComponent<SpriteRenderer>().sprite = citySprites[0].srpite;
        tile.AddComponent<Building>();

    }



}
