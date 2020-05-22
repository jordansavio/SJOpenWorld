using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMulti : MonoBehaviour
{
    public Transform[] T;
    public float speed;
    public GameObject Shot;
    int index;

    void Start()
    {
        index = Random.Range(0, 2);
        Invoke("Fire", 0.5f);

    }

    void Update()
    {
        transform.position += Time.deltaTime * speed * transform.forward;
    }

    void Fire()
    {
        Instantiate(Shot, T[index].transform.position + transform.forward, T[index].transform.rotation);
    }
}
