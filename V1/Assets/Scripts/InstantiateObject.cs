using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour {

    public GameObject myPrefabObject = null;
    public int timeLine = 2013;
    


    // Start is called before the first frame update
    void Start()
    {
       // Instantiate(
       //  myPrefabObject,
       // transform.position,
       // Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void Age(int timeLine)
    {
        timeLine+(+10);

        if (timeLine >= 3083)
        {
            timeLine = 3083;
        }

    }

    public void Rejuvenate(int timeLine)
    {
        timeLine+(-10);

        if (timeLine <= 2013)
        {
            timeLine = 2013;
        }
    }
    */
    
}
