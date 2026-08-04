using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Animal))]
public class AnimalEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Animal myTarget = (Animal)target;

        myTarget.nome = EditorGUILayout.TextField("Meu nome", myTarget.nome);
        myTarget.especie = EditorGUILayout.TextField("Minha espécie", myTarget.especie);
        

        if (GUILayout.Button("Botao"))
        {
            Debug.Log("Sou um " + myTarget.especie + " e meu nome é " + myTarget.nome);
        }
    }
}
