using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInact : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-4, 0);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = veloc;
        
    }

    // Update is called once per frame
    void Update()
    {
        float range = 1;
        transform.position = new Vector3(transform.position.x - range * Random.value,
                                          transform.position.y ,
                                          transform.position.z);
    }
}
