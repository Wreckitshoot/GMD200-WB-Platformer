using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerHealth
{
    public static event Action<int> healthChanged;
    private static int _health = 6;
    public static int GetHealth()
    {
        return _health;
    }
    public static void SetHealth(int health)
    {
        if (_health == health)
        {
            return;
        }
        _health = health;
        healthChanged?.Invoke(_health);
    }
    public static void ResetHealth()
    {
        _health = 6;
    }
}
