using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coba1 : MonoBehaviour
{
    public float kecepatan;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += kecepatan * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= kecepatan * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= kecepatan * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += kecepatan * Time.deltaTime;
        }

        transform.position = pos;
    }
}
