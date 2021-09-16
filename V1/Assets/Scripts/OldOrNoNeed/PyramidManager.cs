using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidManager : MonoBehaviour
{
    public int startDate = 2013; 
    public int endDate = 3083; 
    private GameObject PlaceHolder; 
    public GameObject PrefabCube; 
    private GameObject currentLoadedCube;

    public void onSliderChange(float timeLine)
    {

        int currentDate = (int)Mathf.Lerp(startDate, endDate, timeLine);
        print(timeLine);

        
        int amountOfCubes = currentDate / 10;

        for (int i = 0; i < amountOfCubes; i++)
        {

            Vector3 position = GetPosition(timeLine);
            GameObject obj = Instantiate(PrefabCube, position, Quaternion.identity);
        }

    }

    public Vector3 GetPosition(float timeLine)
    {
        Vector3 pos = Vector3.zero;
        return pos;
    }
}
