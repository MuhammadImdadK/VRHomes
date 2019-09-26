using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    // Start is called before the first frame update
    public Material one;
    public Material two;

    void Start()
    {
       
    }

  public void onClick()
    {

        Update1();
        //RenderSettings.skybox = one;
    }

    // Update is called once per frame
    void Update1()
    {
        RenderSettings.skybox = two;
    }
}
