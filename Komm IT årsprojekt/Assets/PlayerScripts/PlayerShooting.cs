using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public static Vector2 LookDirection;
    public GameObject Bullet;
    float BulletSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        LookDirection = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
            rigidbody.velocity = BulletSpeed * LookDirection;
        }
    }
}
