using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform respawn;
    [SerializeField] private PlayerWarp player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            transform.position = respawn.transform.position;
            player.reset_UG();
            PlayerHealth.SetHealth(PlayerHealth.GetHealth() -1 );
        }
        else if (collision.gameObject.CompareTag("Checkpoint"))
        {
            respawn = collision.transform;
        }
        else if (collision.gameObject.CompareTag("EndofLevel"))
        {
            SceneManager.LoadScene("Level_Complete");
        }
    }
}
