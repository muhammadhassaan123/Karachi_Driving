using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    // Start is called before the first frame updat
    public GameObject redBody;
    public GameObject BlueBody;
    void Start()
    {   
        if(CarSelection.CameraType == 1){
            redBody.SetActive(true);
        }
        else{
            BlueBody.SetActive(true);
        }

        
    }

    // Update is called once per frame
    
}
