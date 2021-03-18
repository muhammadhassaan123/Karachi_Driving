using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoretxt;
    public static int MainScorePoints;

    private int privateScore;
    void Update(){
        privateScore=MainScorePoints;
        scoretxt.GetComponent<Text>().text = "Score ="+privateScore;
    }

    // Update is called once per frame
 
}
