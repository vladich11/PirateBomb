using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour
{
    public GameObject bomb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bomb")
        {
            Debug.LogWarning("target hit");
            Destroy(gameObject, 1f);
        }
    }
}
