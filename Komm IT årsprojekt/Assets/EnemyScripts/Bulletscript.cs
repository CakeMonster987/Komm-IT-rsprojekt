using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    public Vector3 Target = Vector3.zero;
    public float Speed = 25f;
    Vector3 direction;



    // Start is called before the first frame update
    void Start()
    {
        direction = (Target - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * Speed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Væg"))
        {
            Destroy(this.gameObject);
        }

        if (CompareTag("PlayerBull"))
        {
            Destroy(this.gameObject);
        }

        if(CompareTag("Player"))
        {
            Debug.Log("Ramt spiller");
        }

    }

}
