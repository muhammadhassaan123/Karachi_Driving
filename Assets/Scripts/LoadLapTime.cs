using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadLapTime : MonoBehaviour
{
    // Start is called before the first frame update
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    private string BestPlayerName;
    public GameObject PlayerNameDisplay;
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");
        BestPlayerName = PlayerPrefs.GetString("BestPlayerName");
        Debug.Log(SecCount);

        MinDisplay.GetComponent<Text>().text=""+MinCount+":";
        SecDisplay.GetComponent<Text>().text=""+SecCount+".";
        MilliDisplay.GetComponent<Text>().text=""+MilliCount;
        PlayerNameDisplay.GetComponent<Text>().text="BestPlayer: "+BestPlayerName;
    }

    // Update is called once per frame
   
}
