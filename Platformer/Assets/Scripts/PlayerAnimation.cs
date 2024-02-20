using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    private bool _facingRight = true;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(_facingRight && _rb.velocity.x < -0.1)
        { 
            Flip();
        }
        else if (!_facingRight && _rb.velocity.x > 0.1)
        {
            Flip();
        }
    }
    private void Flip()
    {
        _facingRight = !_facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
