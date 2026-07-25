using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = 0.1f;

    public string phrase;

    [NaughtyAttributes.Button]

    private void Awake()
    {
        textMesh.text = "";
    }

    public void StartToType()
    {
        StartCoroutine(Type(phrase));
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach (char i in s.ToCharArray())
        {
            textMesh.text += i;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
