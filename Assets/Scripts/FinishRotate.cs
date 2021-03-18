using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRotate : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject ob;
    private int i=0;
    // Update is called once per frame
    void Update()
    {
        //ob.transform.eulerAngles=new Vector3(transform.eulerAngles.x,Input.GetAxis("Horizontal"),transform.eulerAngles.z);
        i++;
        ob.transform.Rotate(0,1,0,Space.World);
        //Debug.Log(ob.transform.position);
    }
}
