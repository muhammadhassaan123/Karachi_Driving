using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpCarChoice : MonoBehaviour
{
    public GameObject redBody;
    public GameObject BlueBody;
    void Start()
    {   
        if(CarSelection.CameraType == 2){
            redBody.SetActive(true);
        }
        else{
            BlueBody.SetActive(true);
        }

        
    }
   
}
