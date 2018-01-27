using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(Map))]
public class MapGenerator : Editor {

    Map map;

    private void OnEnable() {
        map = (Map)target;
    }

    public override void OnInspectorGUI() {
        // base.OnInspectorGUI();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" Sprite ");
        map.spr = (Sprite)EditorGUILayout.ObjectField(map.spr, typeof(Sprite), allowSceneObjects: true);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" Rows ");
        map.rows = EditorGUILayout.IntField(map.rows, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" Columns ");
        map.columns = EditorGUILayout.IntField(map.columns, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" X Offset");
        map.xOffset = EditorGUILayout.FloatField(map.xOffset, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" Z Offset ");
        map.zOffset = EditorGUILayout.FloatField(map.zOffset, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Generate", GUILayout.Width(255))) {
            map.Preview();
        }

    }


}
