using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnergy : MonoBehaviour
{
    public bool IsReady;
    public float speed = 10f;

    private void Update()
    {
        if (IsReady)
        {
            transform.position += Time.deltaTime * speed * transform.forward;
        }
        
    }
}
