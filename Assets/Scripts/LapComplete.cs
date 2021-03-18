using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapCompleteTrig;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    //public GameObject LapTimeBox;
    private string BestPlayerName;

    public GameObject PlayerNameDisplay;

    public GameObject LapCounter;

    private int LapsDone=0;
    private int OpLapsDone=0;
    public GameObject RaceFinish;
    public float RawTime;

    public GameObject mainCameraCube;
    public GameObject Music;
    public GameObject myCar;

    private int cashValue;
    public GameObject[] sphere;
    void Update(){
        
    }
    void OnTriggerEnter(Collider col){
        //For ScoreMode
        if(ModeSelection.seletedMode==1){
            foreach(GameObject sp in sphere){
            sp.SetActive(true);
            //sphere1.setActive(true);
            
            }
        }
        RawTime =PlayerPrefs.GetFloat("RawTime");
        if(LapTimeManger.RawTime <= RawTime){
        
        if(LapTimeManger.secondCount <= 0){
            SecondDisplay.GetComponent<Text>().text= "0" + LapTimeManger.secondCount + ".";
        }
        else{
            SecondDisplay.GetComponent<Text>().text= "" + LapTimeManger.secondCount + ".";
        }
        
        if(LapTimeManger.minutCount <= 0){
            MinuteDisplay.GetComponent<Text>().text= "0" + LapTimeManger.minutCount+ ".";
        }
        else{
            MinuteDisplay.GetComponent<Text>().text= "" + LapTimeManger.minutCount + ".";
        }
        MilliDisplay.GetComponent<Text>().text =""+ LapTimeManger.milliSecCount;
        if(col.CompareTag("DreamCar01")){
            BestPlayerName="Opponent";
        }else{
            BestPlayerName="You";
        }
        
        PlayerNameDisplay.GetComponent<Text>().text=""+BestPlayerName;
        }
        //Saving Player Name
        if(!col.CompareTag("DreamCar01")){
            LapsDone++;

            
        }else{
            OpLapsDone++;
        }
        
        

        PlayerPrefs.SetInt("MinSave",LapTimeManger.minutCount);
        PlayerPrefs.SetInt("SecSave",LapTimeManger.secondCount);
        PlayerPrefs.SetFloat("MilliSave",LapTimeManger.milliSecCount);
        PlayerPrefs.SetString("BestPlayerName",BestPlayerName);
        PlayerPrefs.SetFloat("RawTime",LapTimeManger.RawTime);
        
        LapTimeManger.minutCount=0;
        LapTimeManger.secondCount=0;
        LapTimeManger.milliSecCount=0;
        LapTimeManger.RawTime=0;    
        LapCounter.GetComponent<Text>().text=""+ LapsDone;
        if(LapsDone==2){
            StartCoroutine(Racefinished());
            cashValue+=50;
            PlayerPrefs.SetInt("Cash: ",cashValue);

        }
        else{
        HalfLapCompleteTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        }
        if(OpLapsDone ==2){
            //Race End;
        }
        
        
    }
    // Start is called before the first frame update
    IEnumerator Racefinished(){
        RaceFinish.SetActive(true);
        mainCameraCube.SetActive(false);        
        Music.SetActive(false);
        CarController.m_Topspeed= 0.0f;
        yield return  new WaitForSeconds(10);
       
        mainCameraCube.SetActive(true);
        RaceFinish.SetActive(false);
        
    }
}
