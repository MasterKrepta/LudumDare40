using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("drag");
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("dragging");
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("end drag");
    }
}
