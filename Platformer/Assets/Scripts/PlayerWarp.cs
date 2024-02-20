using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool in_UG = false;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private int UG_distance = 50;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!in_UG)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - UG_distance);
                in_UG = true;
            }
            else if (in_UG)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + UG_distance);
                in_UG = false;
            }
        }
    }
    public void reset_UG()
    {
        in_UG = false;
    }
}
