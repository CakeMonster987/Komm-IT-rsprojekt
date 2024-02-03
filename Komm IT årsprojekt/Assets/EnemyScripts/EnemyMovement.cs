using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform currentTarget;
    public Transform Player;
    private WaitForSeconds waitForSeconds;


    Rigidbody2D rb;
    private float Speed = 4f;
    private float ShootingRange = 7f;
    public GameObject Bog;

    private int hp = 2;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        currentTarget = Player;

        hp = 4;

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        Vector3 direction = currentTarget.position - transform.position;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * Speed;


        if (Vector3.Distance(transform.position, Player.position) < 99999)
        {
            currentTarget = Player;
        }

        if (Vector3.Distance(transform.position, Player.position) < ShootingRange)
        {
            if (Timer > 1.3f)
            {
                Timer = 0;
                Shoot();
            }
        }


    }
    
    private void Shoot()
    {
        GameObject tempBullet = Instantiate(Bog, transform.position, Quaternion.identity);
        Vector3 tempTarget = Player.position;
        tempTarget.z = 0;
        tempBullet.GetComponent<Bulletscript>().Target = tempTarget;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Bullet")
        {
            hp -= 1;
        }
    }
    private void FixedUpdate()
    {
        if (hp == 0)
        {
            Destroy(this.gameObject);
        }
    }

}
