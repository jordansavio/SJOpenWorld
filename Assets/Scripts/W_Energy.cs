using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Energy : MonoBehaviour
{

    public GameObject Shot;
    public Transform ShotTarget;
    public Transform Spawn;
    float FrameRate;
    public float EnergyPower;
    public float Fire;
    public bool isFire;
    public bool isReady;
    public float speed;

    private void FixedUpdate()
    {
        FrameRate += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && !isFire)
        {
            isFire = true;   
            GameObject s = Instantiate(Shot, Spawn.transform.position, Spawn.transform.rotation) as GameObject;
            s.transform.parent = Spawn;
            ShotTarget = s.transform;
            return;

        }


        if (Input.GetKey(KeyCode.Space) && FrameRate >= Fire && isFire)
        {
            isReady = true;
            FrameRate = 0f;
            ShotTarget.localScale = new Vector3(ShotTarget.localScale.x + EnergyPower, ShotTarget.localScale.y + EnergyPower, ShotTarget.localScale.z + EnergyPower);
            
        }

        if (Input.GetKeyUp(KeyCode.Space) && isReady)
        {
            ShotTarget.transform.parent = null;
            ShotTarget.GetComponent<WeaponEnergy>().IsReady = true;
            
            isFire = false;
            isReady = false;
        }
    }
}
