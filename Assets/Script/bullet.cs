using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField] private float speed = 60f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);


        

    }
}
