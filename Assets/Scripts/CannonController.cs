using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{

    //Cannon Rotation Variables
    public int speed;
    public float friction;
    public float lerpSpeed;
    float xDegrees;
    float yDegrees;
    Quaternion fromRotation;
    Quaternion toRotation;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.transform.gameObject.tag == "Cannon")
            {
                if (Input.GetMouseButton(1))
                {
                    xDegrees -= Input.GetAxis("Mouse Y") * speed * friction;
                    yDegrees -= Input.GetAxis("Mouse X") * speed * friction;
                    fromRotation = transform.rotation;
                    toRotation = Quaternion.Euler(xDegrees, yDegrees, 0);
                    transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * lerpSpeed);
                }
            }
        }
    }
}
