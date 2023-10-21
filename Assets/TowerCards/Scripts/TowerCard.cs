using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerCard : MonoBehaviour
{
    public GameObject plantInstance;
    private GameObject plantDragInstance;
    private GameObject plantCardInstance;

    public void OnMouseDrag()
    {
        if (plantDragInstance != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            worldPosition.z = 0;
            plantDragInstance.transform.position = worldPosition;
        }
    }

    public void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0;
        plantDragInstance = Instantiate(plantInstance, worldPosition, Quaternion.identity);
    }

    public void OnMouseUp()
    {
        if (plantDragInstance != null)
        {
            //Destroy(plantDragInstance);
        }
    }
}
