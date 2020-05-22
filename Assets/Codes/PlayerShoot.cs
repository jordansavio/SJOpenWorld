using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject[] Weapons;
    int indexWeapon = 7;
    float timeToNext;

    void Update()
    {
        float movx = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-movx, 0, 0));

        timeToNext += Time.deltaTime;
        if (Input.GetKey(KeyCode.Q) && timeToNext >= 1f)
        {
            timeToNext = 0;
            for (int i = 0; i < 8; i++)
            {
                Weapons[i].SetActive(false);
            }
            indexWeapon++;
            if (indexWeapon >= 8)
            {
                indexWeapon = 0;
            }

            Weapons[indexWeapon].SetActive(true);

        }
    }



}
