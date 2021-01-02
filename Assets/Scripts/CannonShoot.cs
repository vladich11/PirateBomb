using System.Collections;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
   public Transform shootPos;
    public GameObject sphere;
    public float shootPower;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Instantiate(sphere, shootPos.position, shootPos.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shootPower);    
    }

}
