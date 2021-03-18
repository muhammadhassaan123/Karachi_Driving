using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(toMenu());
    }

    // Update is called once per frame
    IEnumerator toMenu(){
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(1);
    }
}
