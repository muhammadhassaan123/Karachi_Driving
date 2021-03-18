using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManger : MonoBehaviour
{
    public static int minutCount;
    public static int secondCount;
    public static float milliSecCount;
    public static string milliDisplay;
    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;

    public static float RawTime;

    // Update is called once per frame
    void Update()
    {
        milliSecCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        milliDisplay=milliSecCount.ToString("F0");
        milliBox.GetComponent<Text>().text="0" + milliDisplay;
        
        if(milliSecCount >= 10){
                milliSecCount=0;
                secondCount++;
        }
        if(secondCount <= 9){
            secondBox.GetComponent<Text>().text ="0" + secondCount + ".";
        }else{
            secondBox.GetComponent<Text>().text ="" + secondCount + ".";
        }
        if(secondCount >= 60 ){
            secondCount = 0;
            minutCount++;
        }
        if(minutCount <= 1){
            minuteBox.GetComponent<Text>().text = "0" + minutCount + ":";
        }
    }
}
