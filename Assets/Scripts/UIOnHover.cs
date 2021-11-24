using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 cachedScale;
    private float scaleFactor = 1.25f;

    void Start()
    {
        cachedScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        transform.localScale *= scaleFactor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        transform.localScale = cachedScale;
    }
}
