using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SlotBoxData))]
public class InspectorEditor : Editor
{
    //���л�����
    private SerializedObject serializedObject;


    //���л�����
    private SerializedProperty type;
    private SerializedProperty buildtype;
    private SerializedProperty gunMagazine;
    private SerializedProperty magicMagazine;

    void OnEnable()
    {
        serializedObject = new SerializedObject(target);

        type = serializedObject.FindProperty("type");
        buildtype = serializedObject.FindProperty("buildtype");
        gunMagazine = serializedObject.FindProperty("gunMagazine");
        magicMagazine = serializedObject.FindProperty("magicMagazine");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(type);
        EditorGUILayout.PropertyField(buildtype);

        if (type.enumValueIndex == 0 && buildtype.enumValueIndex == 1)
        {
            EditorGUILayout.PropertyField(gunMagazine);
        }
        else if (type.enumValueIndex == 0 && buildtype.enumValueIndex == 2)
        {
            EditorGUILayout.PropertyField(magicMagazine);
        }

        serializedObject.ApplyModifiedProperties();

    }
}
