using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float skyBoxRotationSpeed=10;
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation",skyBoxRotationSpeed*Time.time);
        
    }
}
