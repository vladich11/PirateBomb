using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z >= 35f)
        {
            dirRight = false;
        }

        if (transform.position.z <= -15)
        {
            dirRight = true;
        }

    }
}
