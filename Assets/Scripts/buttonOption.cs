using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonOption : MonoBehaviour
{
   public void playGame(){
       SceneManager.LoadScene(2);
   }
   public void track2(){
       SceneManager.LoadScene(4);
   }

    public void quiteGame(){
        Application.Quit();
    }

    public void selectTrack(){
        SceneManager.LoadScene(3);
    }

     public void goToMenu(){
        ModeSelection.seletedMode=0;
        SceneManager.LoadScene(1);
    }

     public void creditsScene(){
        SceneManager.LoadScene(5);
    }
}
