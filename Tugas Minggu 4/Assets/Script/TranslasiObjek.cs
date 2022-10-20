using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    public float speed;
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;

    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1, 0, 0);
   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kekanan * speed * Time.deltaTime);
    }
}
