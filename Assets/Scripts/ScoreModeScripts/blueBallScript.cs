using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    void OnTriggerEnter(){
        MainScore.MainScorePoints+=50;
        sphere.SetActive(false);
    }
}
