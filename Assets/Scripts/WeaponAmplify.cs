using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAmplify : MonoBehaviour
{
    public GameObject Shot;
    public float size;
    public float timeToSize;
    public float speed = 15;

    private void Start()
    {
        Invoke("Amplify", timeToSize);
        Invoke("Cancel", 10);
    }

    private void Update()
    {
        transform.position += Time.deltaTime * speed * transform.forward;
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
