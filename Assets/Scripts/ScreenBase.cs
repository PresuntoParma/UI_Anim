using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
using Unity.VisualScripting;

namespace Screens
{
    public enum ScreenType
    {
        Main,
        Shop,
        Inventory
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public List<Transform> listOfObjects;
        public List<Typper> listOfPhrases;

        public bool startHiden = false;

        [Header("Animations")]
        public float delayBetweenObjects = 0.05f;
        public float animationDuration = 0.3f;

        private void Start()
        {
            if (startHiden) HideObjects();
        }

        [Button]
        public void Show()
        {
            Debug.Log("Show");
            ShowObjects();
        }

        [Button]
        public void Hide()
        {
            Debug.Log("Hide");
            HideObjects();
        }

        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
        }

        private void ShowObjects()
        {
            for(int i = 0; i < listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];

                obj.gameObject.SetActive(true);
                obj.DOScale(0, animationDuration).From().SetDelay(delayBetweenObjects * i);
            }

            Invoke(nameof(StartType), delayBetweenObjects * listOfObjects.Count);
        }

        private void StartType()
        {
            for(int i = 0; i < listOfPhrases.Count; i++)
            {
                listOfPhrases[i].StartToType(); ;
            }
        }

        private void ForceShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
        }
    }
}
