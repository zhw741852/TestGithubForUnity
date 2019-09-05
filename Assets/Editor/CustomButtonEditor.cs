using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(CustomButton))]
public class CustomButtonEditor : Editor {

    SerializedProperty onClick;
    float value;
    private void OnEnable()
    {
        this.onClick = serializedObject.FindProperty("onClick");
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        //EditorGUILayout.PropertyField(onClick);

        serializedObject.ApplyModifiedProperties();

        value  = EditorGUILayout.Slider("生命值",value, 0, 100);
        EditorGUI.ProgressBar(GUILayoutUtility.GetRect(20, 20), value/100, "生命值:"+value);

    }
}
