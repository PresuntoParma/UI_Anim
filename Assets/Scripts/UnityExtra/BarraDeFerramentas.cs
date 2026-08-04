using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraDeFerramentas : MonoBehaviour
{
    public static GameObject obj;

#if UNITY_EDITOR
    [UnityEditor.MenuItem("EBAC/TEST")]
    public static void CriarObj()
    {
        Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
    }
#endif
}
