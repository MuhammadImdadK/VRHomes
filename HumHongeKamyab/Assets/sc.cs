using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown Mdropdown;
      public Material [] mat = new Material[5];
      public Material [,] mat2 = new Material[5,5];
   
        List<string> DD = new List<string>(){"Select Room","Room 1","Room 2","Room 3","Room 4","Room 5"};
        List<string> DD1=new List<string>(){"Select Room","Room 4"};
        List<string> DD2=new List<string>(){"Select Room","Room 4"};
        List<string> DD3=new List<string>(){"Select Room","Room 4","Room 5"};
        List<string> DD4=new List<string>(){"Select Room","Room 1","Room 2","Room 3","Room 5"};
        List<string> DD5=new List<string>(){"Select Room","Room 4","Room 3"};
    Material matSetter ;
    void Start()
    {
        matSetter=mat[0];
            Mdropdown.ClearOptions();
        PopulateDropDown();
    
    }

  public void onClick()
    {

        Indexer();
        //RenderSettings.skybox = one;
    }
 void PopulateDropDown()
    {
        
       Mdropdown.AddOptions(DD1);
         
    }
    public void Indexer ()
    {
        
        if(Mdropdown.options[Mdropdown.value].text=="Room 1")
        {
            matSetter=mat[0];
            Mdropdown.ClearOptions();
             
            Mdropdown.AddOptions(DD1);
        }
        else if(Mdropdown.options[Mdropdown.value].text=="Room 2")
        {
            matSetter=mat[1];
            Mdropdown.ClearOptions();
             
            Mdropdown.AddOptions(DD2);
        }
        else if(Mdropdown.options[Mdropdown.value].text=="Room 3")
        {
            matSetter=mat[2];
            Mdropdown.ClearOptions();
             
            Mdropdown.AddOptions(DD3);
        }
        else if(Mdropdown.options[Mdropdown.value].text=="Room 4")
        {
            matSetter=mat[3];
            Mdropdown.ClearOptions();
             
            Mdropdown.AddOptions(DD4);
        }
        else if(Mdropdown.options[Mdropdown.value].text=="Room 5")
        {
            matSetter=mat[4];
            Mdropdown.ClearOptions();
             
            Mdropdown.AddOptions(DD5);
        }
        
        Update1();
    }
    // Update is called once per frame
    void Update1()
    {
        RenderSettings.skybox =matSetter;
    }
}
