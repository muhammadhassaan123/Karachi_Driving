using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class CountDown : MonoBehaviour
{
    public GameObject CountVar;
    public AudioSource GetReady;

    public AudioSource GoAudio;
    public GameObject LapTimer;

    public GameObject CarControl;

    public GameObject CarAiControl;
    public AudioSource LevelAudio;
     
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart(){
        yield return new WaitForSeconds(0.5f);
        CountVar.GetComponent<Text>().text="3";
        GetReady.Play();
        CountVar.SetActive(true);
        yield return new WaitForSeconds(1);
        CountVar.SetActive(false);
        CountVar.GetComponent<Text>().text="2";
        GetReady.Play();
        CountVar.SetActive(true);
        yield return new WaitForSeconds(1);
        CountVar.SetActive(false);
        CountVar.GetComponent<Text>().text="1";
        GetReady.Play();
        CountVar.SetActive(true);
        GoAudio.Play();
        LapTimer.SetActive(true);
        CarControl.SetActive(true);
        CarAiControl.GetComponent<CarAIControl>().enabled = true;
        LevelAudio.Play();
    }

    
}
