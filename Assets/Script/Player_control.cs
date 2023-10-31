using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_control : MonoBehaviour
{
    [SerializeField] private float speed = 15f;

    private float horizontalInput;

    private float xRange = 15f;

    [SerializeField] private GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * horizontalInput);

        PlayerBounds();


        if (Input.GetKeyDown("space"))
        {
            Fire();
            
        }


        
    }

    private void PlayerBounds()
    {
        Vector3 pos = transform.position;

        if(pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        if(pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }




    }

    private void Fire()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }



}
