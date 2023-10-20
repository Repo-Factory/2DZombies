using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerCard : MonoBehaviour, IDragHandler, IPointerUpHandler
{
    public GameObject towerInstance;
    private GameObject towerDragInstance;
    private GameObject towerCardInstance;
    public Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        if (towerDragInstance != null)
        {
            towerDragInstance.transform.position = Input.mousePosition;
        }
    }

    public void OnMouseDown()
    {
        towerDragInstance = Instantiate(towerInstance, Input.mousePosition, Quaternion.identity);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (towerDragInstance != null)
        {
            Destroy(towerDragInstance);
        }
    }
}
