using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static GameConstants;


public class TowerCard : MonoBehaviour
{
    public GameObject plantInstance;
    private GameObject plantDragInstance;
    private GameObject plantCardInstance;


    public const float GRIDLEFT = -5;
    public const float GRIDBOTTOM = -4;
    public const float GRIDRIGHT = 5;
    public const float GRIDTOP = 4;
    public const float GRIDSIZE_X = 10;
    public const float GRIDSIZE_Y = 6;

    public float[] valid_x_points = new float[8];
    public float[] valid_y_points = {-2.5f,-1.5f,-0.5f,0.5f,1.5f,2.5f};

    public void Start()
    {
        const float interval = (float)FIELD_SPACE / (float)COLUMNS;
        float currentIndex = FIELD_START + .5f;
        int i = 0;
        while (currentIndex < FIELD_END)
        {
            valid_x_points[i] = currentIndex;
            currentIndex += interval;
            i += 1;
        }
    }

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
            if(inGrid(plantDragInstance.transform.position))
            {
                plantDragInstance.transform.position = SnapToNearestGridPosition(plantDragInstance.transform.position);
            }
            else
            {
                Destroy(plantDragInstance);
            }
        }
    }
    public bool inGrid(Vector3 position)
    {
        return position.x > GRIDLEFT && position.x < GRIDRIGHT && position.y > GRIDBOTTOM && position.y < GRIDTOP;
    }

    public float findClosest(float target, float[] validPoints)
    {
        float min = 1000000;
        int index = 0;
        int i = 0;

        foreach (float point in validPoints)
        {
            float distance = Math.Abs(target - point);
            if (distance < min)
            {
                min = distance;
                index = i;
            }
            i += 1;
        }

        return validPoints[index];
    }

    private Vector3 SnapToNearestGridPosition(Vector3 position)
    {
        float x = findClosest(position.x, valid_x_points);
        float y = findClosest(position.y, valid_y_points);
        return new Vector3(x, y, 0);
    }
}
