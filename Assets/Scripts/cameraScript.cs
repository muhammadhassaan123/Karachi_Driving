using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;

    void Update()
    {
        if( Input.GetButtonDown("ViewMode")){
            if(CamMode==2){
                CamMode=0;
            }
            else{
                CamMode++;
            }   
            StartCoroutine (ModeChange());
        }
        
    }
    IEnumerator ModeChange(){
        yield return new WaitForSeconds(0.01f);
        if (CamMode==0){
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
            
            
        }
        if (CamMode==1){
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
            
            
        }
        if (CamMode==2){
            FPCam.SetActive(true);
            FarCam.SetActive(false);
            
            
        }
    }
}
