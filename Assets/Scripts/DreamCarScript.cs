using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DreamCarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TheMarker;
    //public GameObject[] Markers;
    public GameObject check;
    private int MarkTracker=0;
    public int noOfMarks;
    //private int q=0;

    // Update is called once per frame
    void Update()
    {
        

        
    }
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag =="DreamCar01"){
             TheMarker.transform.position = check.transform.GetChild(MarkTracker).gameObject.transform.position;
             //TheMarker.transform.rotation = check.transform.GetChild(MarkTracker).gameObject.transform.rotation;
             //TheMarker.transform.position = Markers[q].transform.position;
             //q++;
            this.GetComponent<CapsuleCollider>().enabled=false; 
            MarkTracker++;
            if(MarkTracker == noOfMarks){
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(0.001f);
            this.GetComponent<CapsuleCollider>().enabled=true;
        }
    }
}
