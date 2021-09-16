using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearCounter : MonoBehaviour
{
    public int startDate = 2013;
    public Slider sliderUI;
    Text year;
    
    // Start is called before the first frame update
    void Start()
    {

        /* InstantiateObject timeLine = GetComponent<InstantiateObject>(); */
        
        year = GetComponent<Text>();
        ShowSliderValue();
    }

    
    public void ShowSliderValue()
    {

        string sliderMessage = "Jahr: " + sliderUI.value;
        year.text = sliderMessage;
    }

}
