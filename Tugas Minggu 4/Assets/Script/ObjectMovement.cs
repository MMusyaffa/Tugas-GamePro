using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;
    public int aksi;
    public float speedRotasi;

    Vector3 maju;
    Vector3 mundur;

    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;

    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1, 0, 0);
        kekiri = new Vector3(-1, 0, 0);
        keatas = new Vector3(0, 1, 0);
        kebawah = new Vector3(0, -1, 0);

        maju = new Vector3(0, 0, 1);
        mundur = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi)
        {
            case 0:
                transform.position = transform.position + (kekanan * speed * Time.deltaTime);
                break;
            case 1:
                transform.position = transform.position + (kekiri * speed * Time.deltaTime);
                break;
            case 2:
                transform.position = transform.position + (keatas * speed * Time.deltaTime);
                break;
            case 3:
                transform.position = transform.position + (kebawah * speed * Time.deltaTime);
                break;
            case 4:
                transform.rotation = transform.rotation * Quaternion.Euler(mundur * speedRotasi * Time.deltaTime);
                break;
            case 5:
                transform.rotation = transform.rotation * Quaternion.Euler(maju * speedRotasi * Time.deltaTime);
                break;
        }
  
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "enemyTag")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
}
