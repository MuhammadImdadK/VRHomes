using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown Mdropdown;
      public Material [] mat = new Material[5];
   
    Material matSetter ;
    void Start()
    {
        matSetter=mat[0];
    
    }

  public void onClick()
    {

        Indexer();
        //RenderSettings.skybox = one;
    }

    public void Indexer ()
    {
        matSetter=mat[Mdropdown.value];
        Update1();
        
    }
    // Update is called once per frame
    void Update1()
    {
        RenderSettings.skybox =matSetter;
    }
}
