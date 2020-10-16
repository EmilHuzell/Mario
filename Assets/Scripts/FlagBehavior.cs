using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool touched = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject flag = GameObject.Find("Flag");
        Debug.Log(flag.name);
        if(touched)
        {
            flag.transform.position = new Vector3(flag.transform.position.x,-0.79f,flag.transform.position.z);

        }
        
    }
}
