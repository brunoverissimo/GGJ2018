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


    Hex[,] grid;

    // Use this for initialization
    void Start() {

        GenerateField();

    }


    public void GenerateField() {

        grid = new Hex[columns, rows];

        for (int column = 0; column < columns; column++) {
            for (int row = 0; row < rows; row++) {

                //Hex hex = new Hex(column, row, padding);
                //grid[column, row] = hex;


                //GameObject go = new GameObject(string.Format("Tile_{0}_{1}_{2}", hex.gridPosition.q, hex.gridPosition.r, hex.gridPosition.s));
                //go.transform.SetParent(this.transform);
                //go.transform.localScale = new Vector3(1.45f, 1.45f, 1);
                //go.transform.position = hex.worldPosition;
                //go.AddComponent<SpriteRenderer>();
                //go.GetComponent<SpriteRenderer>().sprite = spr;

                //GameObject go = Instantiate(hexPreFab, hex.worldPosition, Quaternion.identity, this.transform) as GameObject;
                //go.GetComponent<FieldTile>().textMesh.text = string.Format(go.GetComponent<FieldTile>().textMesh.text, hex.gridPosition.r, hex.gridPosition.q);
                //go.name = string.Format("HEX_{0}_{1}", hex.gridPosition.r, hex.gridPosition.q);
            }

        }

    }


    // Size of the map in terms of number of hex tiles
    // This is NOT representative of the amount of 
    // world space that we're going to take up.
    // (i.e. our tiles might be more or less than 1 Unity World Unit)





    public void Preview() {


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

                GameObject hex_go = new GameObject(string.Format("Tile_{0}_{1}", x, y));
                hex_go.transform.SetParent(this.transform);
                //hex_go.transform.localScale = new Vector3(1.45f, 1.45f, 1);
                hex_go.transform.position = new Vector3(xPos, y * zOffset, 1f);
                hex_go.AddComponent<Hex>();
                hex_go.AddComponent<SpriteRenderer>();
                hex_go.GetComponent<SpriteRenderer>().sprite = spr;


                // GameObject hex_go = (GameObject)Instantiate(hexPrefab, new Vector3(xPos, 0, y * zOffset), Quaternion.identity);

                // Name the gameobject something sensible.
                //hex_go.name = "Hex_" + x + "_" + y;

                // Make sure the hex is aware of its place on the map
                hex_go.GetComponent<Hex>().x = x;
                hex_go.GetComponent<Hex>().y = y;

                // For a cleaner hierachy, parent this hex to the map
                //hex_go.transform.SetParent(this.transform);

                // TODO: Quill needs to explain different optimization later...
                hex_go.isStatic = true;

            }
        }

    }


}

//public Hex GetHex(int column, int row) {

//    return grid[column, row];

//}

//public GameObject GetHexGameObject(Hex hex) {

//    GameObject go = GameObject.Find(string.Format("HEX_{0}_{1}", hex.gridPosition.r, hex.gridPosition.q));

//    return go;

//}


