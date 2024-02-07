using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Væg"))
        {
            Destroy(this.gameObject);
        }

        if (CompareTag("Bog"))
        {
            Destroy(this.gameObject);
        }

        if (CompareTag("Fjende"))
        {
            Destroy(gameObject);
        }

    }
}
