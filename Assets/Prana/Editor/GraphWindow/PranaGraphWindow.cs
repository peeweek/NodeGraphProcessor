using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GraphProcessor;

namespace Prana
{
    public class PranaGraphWindow : BaseGraphWindow
    {
        [MenuItem("Window/Visual Effects/Prana")]
        public static BaseGraphWindow Open()
        {
            var graphWindow = GetWindow<PranaGraphWindow>();

            graphWindow.Show();

            return graphWindow;
        }

        protected override void Initialize(BaseGraph graph)
        {
            titleContent = new GUIContent("Prana");

            var graphView = new CustomContextMenuGraphView();

            rootView.Add(graphView);

            graphView.Add(new PranaToolbarView(graphView));
        }
    }

}
