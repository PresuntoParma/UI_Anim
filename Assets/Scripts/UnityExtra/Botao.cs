using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botao : MonoBehaviour
{
    public string[] nomes;
    public TextMeshProUGUI text;

    public void GetRandomName()
    {
        text.text = nomes.GetRandom();
    }
}
