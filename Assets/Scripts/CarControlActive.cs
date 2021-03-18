using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject CarControl;
    void Start()
    {
        CarControl.GetComponent<CarUserControl>().enabled = true;
    }

    // Update is called once per frame
}
