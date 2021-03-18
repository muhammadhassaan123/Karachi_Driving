using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setMode : MonoBehaviour
{
    public GameObject OpCar;
    public GameObject raceModeTextGroup;
    public GameObject scoreModeTextGroup;
    public GameObject scoreModeballs;
    // Start is called before the first frame update
    void Start()
    {
        if(ModeSelection.seletedMode ==1){
            OpCar.SetActive(false);
            raceModeTextGroup.SetActive(false);
            scoreModeTextGroup.SetActive(true);
            scoreModeballs.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
