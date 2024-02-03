using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTeleporter : MonoBehaviour
{
    public Transform PlayerPos;
    void Update()
    {
        transform.position = new Vector3(PlayerPos.transform.position.x, PlayerPos.transform.position.y, -10);
    }
}
