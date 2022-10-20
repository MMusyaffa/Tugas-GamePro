using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobaArray : MonoBehaviour
{
    public string[] items;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < items.Length; i++)
            Debug.Log(items[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
