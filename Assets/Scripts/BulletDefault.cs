﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDefault : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += Time.deltaTime * speed * transform.forward;
    }
    
}
