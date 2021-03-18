using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{
    public static int seletedMode;//0 for racemode , 1 for score mode;
      public GameObject trackWindow;
   public GameObject ModeWindow;
   public void  raceMode ()
    {
        trackWindow.SetActive(true);
       ModeWindow.SetActive(false);
        
    }
    public void scoreMode(){
        seletedMode=1;
        trackWindow.SetActive(true);
       ModeWindow.SetActive(false);
    }
}
