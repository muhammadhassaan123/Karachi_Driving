using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class disableTRACK1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Track1Btn;
    void Start()
    {
        if(ModeSelection.seletedMode==1){
            Track1Btn.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
