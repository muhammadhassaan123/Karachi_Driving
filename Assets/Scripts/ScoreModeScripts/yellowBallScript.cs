using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    void OnTriggerEnter(){
        MainScore.MainScorePoints+=75;
        Debug.Log("Collided");
        sphere.SetActive(false);
        gameObject.SetActive(false);
    }
}
