using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour {

    public int startDate = 2013;
    public int endDate = 3083;
   
    public void onSliderChange(float timeLine)
    {
        
        int currentDate = (int) Mathf.Lerp(startDate, endDate, timeLine);
        print(currentDate);

    }

    
    
}
