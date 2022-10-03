using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class Snapper
{

    const string UNDO_STR_SNAP = "snap objects";

    [MenuItem ("Edit/Snap Selected Object %&S", isValidateFunction:true)]
    public static bool SnapTheThingsValidate()
    {
        return Selection.gameObjects.Length > 0;
    }

    [MenuItem("Edit/Snap Selected Object %&S")]
    public static void SnapTheThings()
    {
        foreach (GameObject go in Selection.gameObjects)
        {
            Undo.RecordObject(go.transform, UNDO_STR_SNAP);
            go.transform.position = go.transform.position.Round();
            
        }
    }
}