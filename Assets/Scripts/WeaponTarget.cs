using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTarget : MonoBehaviour
{

    public GameObject Enemy;
    bool isFollow;
    public float speed = 15;
    public float timeToTarget;

    void Start()
    {
       Enemy = GameObject.Find("Enemy");
       Invoke("Iniciar", timeToTarget);
       Invoke("Cancel", 10);
    }

    private void Update()
    {
        if (isFollow)
        {
            transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position,1);
        }
        else
        {
            transform.position += Time.deltaTime * speed * transform.forward;
        }
    }

    void Iniciar()
    {
        isFollow = true;
    }

    void Cancel()
    {
        this.gameObject.SetActive(false);
    }


}
