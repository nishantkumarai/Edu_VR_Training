using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation hingehere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            hingehere[hingehere.clip.name].speed = 1;
            hingehere.Play();
        }

        if (Input.GetKey(KeyCode.F))
        {
            hingehere[hingehere.clip.name].speed = -1;
            hingehere.Play();

        }
    }
}