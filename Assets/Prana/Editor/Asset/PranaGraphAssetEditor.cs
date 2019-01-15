using UnityEngine;
using UnityEditor;

namespace Prana
{
    [CustomEditor(typeof(PranaGraphAsset))]
    public class PranaGraphAssetEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            if(GUILayout.Button("Edit"))
            {
                PranaGraphWindow.Open().InitializeGraph(target as PranaGraph);
            }
        }
    }
}


