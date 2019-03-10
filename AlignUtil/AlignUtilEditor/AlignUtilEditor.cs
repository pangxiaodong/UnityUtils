using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityEditor
{
    [CustomEditor(typeof(AlignUtil))]
    public class AlignUtilEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            AlignUtil util = target as AlignUtil;
            if (GUILayout.Button("Set Align"))
            {
                util.SetAlign();
            }
        }
    }
}
