using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("V�g"))
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
