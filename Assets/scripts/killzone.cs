using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour
{
    public GameObject spawn;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = spawn.transform.position;
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("scena el jugador se pasara al spawn");
        }
    }

}