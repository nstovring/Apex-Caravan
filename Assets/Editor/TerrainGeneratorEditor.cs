using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(TerrainGenerator))]
public class TerrainGeneratorEditor : Editor {
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        TerrainGenerator gen = target as TerrainGenerator;

        if (GUILayout.Button("Generate Terrain"))
        {
            gen.GenerateTerrain();
        }

        if (GUILayout.Button("Erase Terrain"))
        {
            gen.EraseTerrain();
        }
    }
}
