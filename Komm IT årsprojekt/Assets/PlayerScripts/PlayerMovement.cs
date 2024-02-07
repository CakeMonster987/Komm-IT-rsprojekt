using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Speed = 7f;
    [SerializeField] Rigidbody2D rb;
    private Vector2 moveInput;
    int HP = 3;

    //public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        if(moveInput.magnitude > 0.6f)
        {
            PlayerShooting.LookDirection = moveInput;
        }
        rb.velocity = moveInput * Speed;

        if (HP == 0)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Bog"))
        {
            HP--;
        }
    }

}
