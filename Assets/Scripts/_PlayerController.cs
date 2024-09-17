using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class _PlayerController : MonoBehaviour
{
    private _GameManager gameManager;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool hasStarted = false;
    public bool isDead;

    public AudioSource _audioSource;
    public AudioClip[] clips;
    
    void Start()
    {
        gameManager = _GameManager.gameManager;
        hasStarted = false;
        isDead = false;
        rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        

    }
    void Update()
    {   
        if(hasStarted)
        {
            if(Input.GetButtonDown("Jump"))
            {
                Jump();
                _audioSource.clip = clips[0];
                _audioSource.Play();
            }
        } else {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0;
        }
        if(Input.GetButtonDown("Jump"))
            {
                hasStarted = true;    
                rb.gravityScale = 1;
            }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Trigger"))
        {
            gameManager._spawner.GenerateFork(transform.position);
        }

        if(col.CompareTag("Fork"))
        {
            _audioSource.clip = clips[1];
            _audioSource.Play();
            isDead = true;
        }
    }
}
    