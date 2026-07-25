using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public float finalScale = 1.25f;
    public float scaleDuration = 0.05f;

    private Tween currentTween;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        currentTween = transform.DOScale(finalScale, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        currentTween.Kill();
        transform.localScale = Vector3.one;
    }
}
