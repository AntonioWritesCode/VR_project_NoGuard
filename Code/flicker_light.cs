using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker_light : MonoBehaviour
{
    public Light lightPost;

    // Update is called once per frame
    void Update()
    {
        if(Random.value > 0.9)
        {
            if(lightPost.enabled == true)
            {
                lightPost.enabled = false;
            }
            else
            {
                lightPost.enabled = true;
            }
        }
    }
}
