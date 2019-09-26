using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DDscript : MonoBehaviour
{
     public Dropdown Mdropdown;
  
    // Start is called before the first frame update
    void Start()
    {
        PopulateDropDown();
    }
    
    
    void PopulateDropDown()
    {
        List<string> DD = new List<string>(){"Room 1","Room 2","Room 3","Room 4","Room 5"};
       Mdropdown.AddOptions(DD);
         
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
