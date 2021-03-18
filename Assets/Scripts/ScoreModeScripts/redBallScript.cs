using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    void OnTriggerEnter(){
        MainScore.MainScorePoints+=100;
        sphere.SetActive(false);
    }
}
