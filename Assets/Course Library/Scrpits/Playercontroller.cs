using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed;
    const float HBound = 10.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        int num1 = 3;
        float result = 1.0f / num1;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        //Don't let the player move off the grass right
        if(transform.position.x > HBound)
        {
            transform.position = new Vector3(HBound, transform.position.y, transform.position.z);
        }
        //Don't let the player move off the grass left
        if (transform.position.x < -HBound)
        {
            transform.position = new Vector3(-HBound, transform.position.y, transform.position.z);
        }
        //Dont let the player move off the grass in front
        if (transform.position.z > 10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        //Dont let the player move off the grass in the back
        if (transform.position.z < -10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }

        float HInput = Input.GetAxis("Horizontal");
        float VInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * HInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * VInput * Time.deltaTime * speed);

    }
}
