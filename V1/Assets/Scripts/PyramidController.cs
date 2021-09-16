using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;
using UnityEngine.UI;

public class PyramidController : MonoBehaviour {

    public int startDate = 2013;
    private GameObject PlaceHolder;
    public GameObject PrefabCube;
    public Text yearLabel;
    private float currentTimeProgress = 8;


    public void Start()
    {
        UpdateYearTextLabel(); 
    }

    public void onSliderChange(float timeLine)
    {
        currentTimeProgress = timeLine;
        int numberOfCubes = (int) timeLine / 10;
        print(numberOfCubes);

        for (int i = 1; i <= numberOfCubes; i++)
        {
            PlaceHolder = GameObject.Find("Cube (" + (i +3) + ")");

            if (PlaceHolder.transform.childCount == 0)
            { 
                GameObject obj = Instantiate(PrefabCube);
                obj.transform.SetParent(PlaceHolder.transform, false);
            }

        }

        for (int i = 1; i <=numberOfCubes; i++)
        {
            PlaceHolder = GameObject.Find("Cube 120");

            if (PlaceHolder.transform.childCount == 1)
            {
                Destroy(GameObject.Find("Cube(Clone)"));
            }
        } 


        UpdateYearTextLabel();

     
    }

    private void UpdateYearTextLabel()
    {
        yearLabel.text = "Jahr: " + (startDate + currentTimeProgress);
    }
}
