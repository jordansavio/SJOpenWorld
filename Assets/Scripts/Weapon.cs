using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject Shot;
    public Transform Spawn;
    float FrameRate;
    public float Fire;

    private void FixedUpdate()
    {
        FrameRate += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && FrameRate >= Fire)
        {
            FrameRate = 0f;
            GameObject s = Instantiate(Shot, Spawn.transform.position + transform.forward, Spawn.transform.rotation) as GameObject;

        }
    }
   
        
}
