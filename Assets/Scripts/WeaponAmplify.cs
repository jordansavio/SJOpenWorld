using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAmplify : MonoBehaviour
{
    public GameObject Shot;
    public float size;
    public float timeToSize;

    private void Start()
    {
        Invoke("Amplify", timeToSize);
        Invoke("Cancel", 10);
    }

    void Amplify()
    {
        transform.localScale = new Vector3(transform.localScale.x + size, transform.localScale.y + size, transform.localScale.z + size);
    }

    void Cancel()
    {
        this.gameObject.SetActive(false);
    }

}
