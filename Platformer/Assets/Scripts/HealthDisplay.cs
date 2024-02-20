using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Image[] pillImages;
    private void OnEnable()
    {
        PlayerHealth.healthChanged += OnhealthChanged;
    }
    private void OnDisable()
    {
        PlayerHealth.healthChanged -= OnhealthChanged;
    }
    private void OnhealthChanged(int obj)
    {
        Debug.Log("Health: " + obj);
        if (obj < 0)
        {
            //death screen
            PlayerHealth.ResetHealth();
            SceneManager.LoadScene("Death_Scene");
        }
        else
        {
            pillImages[obj].gameObject.SetActive(false);
        }
    }
}
