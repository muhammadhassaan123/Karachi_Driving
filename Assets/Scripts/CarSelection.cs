using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelection : MonoBehaviour
{
   public static int CameraType;
   public GameObject ModeWindow;
   public GameObject carWindow;
   public void redCar(){
       CameraType=1;
       ModeWindow.SetActive(true);
       carWindow.SetActive(false);
   }
   public void blueCar(){
       CameraType=2;
       ModeWindow.SetActive(true);
       carWindow.SetActive(false);
   }
}
