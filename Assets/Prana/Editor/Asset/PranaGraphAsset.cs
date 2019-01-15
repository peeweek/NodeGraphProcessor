using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PranaGraphAsset : ScriptableObject
{
    [MenuItem("Assets/Create/Prana Asset")]
    static void CreateAsset()
    {
        CreatePranaGraphAssetAtPath("Assets/PranaGraph.asset");
    }

    [SerializeField]
    PranaGraph Graph;

    [SerializeField]
    Texture[] OutputTextures;


    public static void CreatePranaGraphAssetAtPath(string path)
    {
        PranaGraphAsset asset = CreateInstance<PranaGraphAsset>();
        AssetDatabase.CreateAsset(asset, path);
        asset.OutputTextures = new Texture[0];
        asset.Graph = CreateInstance<PranaGraph>();
        asset.Graph.name = "Prana Graph";
        //asset.Graph.hideFlags = HideFlags.HideInHierarchy;
        
        AssetDatabase.AddObjectToAsset(asset.Graph, asset);
        AssetDatabase.SaveAssets();

    }

}
