using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform respawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            transform.position = respawn.transform.position;
        }
        else if (collision.gameObject.CompareTag("Checkpoint"))
        {
            respawn = collision.transform;
        }
    }
}
