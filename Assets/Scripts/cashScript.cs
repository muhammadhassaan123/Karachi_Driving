using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cashScript : MonoBehaviour
{
    public GameObject cashTxt;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.SetInt("Cash",50);
    }

    // Update is called once per frame
    void Update()
    {
        try{
        
        cashTxt.GetComponent<Text>().text ="Cash: "+PlayerPrefs.GetInt("Cash")+"$";
        }
        catch{
            cashTxt.GetComponent<Text>().text ="Cash:"+0;
        }
    }
}
