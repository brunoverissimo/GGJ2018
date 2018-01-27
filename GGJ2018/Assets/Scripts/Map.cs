using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public Sprite spr;


    [Header("Prefabs")]
    public GameObject hexPreFab;

    [Header("Field Size")]
    [Range(1, 20)]
    public int columns = 1;
    [Range(1, 20)]
    public int rows = 1;

    public float xOffset = 0.375f;
    public float zOffset = 1f;


    GameObject[,] grid;

    // Use this for initialization
    void Start() {


        grid = new GameObject[columns, rows];

        GenerateField();

    }


    public void GenerateField() {

        

        while (transform.childCount > 0) {

            DestroyImmediate(transform.GetChild(0).gameObject);

        }

        for (int x = 0; x < columns; x++) {
            for (int y = 0; y < rows; y++) {

                float xPos = x * xOffset;

                // Are we on an odd row?
                if (y % 2 == 1) {
                    xPos += xOffset / 2f;
                }

                //GameObject hex_go = new GameObject();
                GameObject hex_go = Instantiate(hexPreFab, Vector3.zero, Quaternion.identity) as GameObject;
                hex_go.name = string.Format("Tile_{0}_{1}", x, y);
                hex_go.transform.SetParent(this.transform);
                hex_go.transform.position = new Vector3(xPos, y * zOffset, 1f);
                //hex_go.AddComponent<SpriteRenderer>();
                hex_go.GetComponent<SpriteRenderer>().sprite = spr;

                grid[x, y] = hex_go;

                hex_go.GetComponent<Hex>().x = x;
                hex_go.GetComponent<Hex>().y = y;

                hex_go.isStatic = true;

            }
        }

    }


    // Size of the map in terms of number of hex tiles
    // This is NOT representative of the amount of 
    // world space that we're going to take up.
    // (i.e. our tiles might be more or less than 1 Unity World Unit)





    public void Preview() {


        GenerateField();

    }


    public GameObject GetTile() {

        int x = UnityEngine.Random.Range(1, columns - 1);
        int y = UnityEngine.Random.Range(1, rows - 1);

        return grid[x, y];

    }

}

//public Hex GetHex(int column, int row) {

//    return grid[column, row];

//}

//public GameObject GetHexGameObject(Hex hex) {

//    GameObject go = GameObject.Find(string.Format("HEX_{0}_{1}", hex.gridPosition.r, hex.gridPosition.q));

//    return go;

//}


