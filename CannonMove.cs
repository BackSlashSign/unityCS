using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    float horizontal;
    float vertical;
    public Quaternion horizonLimit = new Quaternion(0,45,0,0);
    public Quaternion verticalLimit = new Quaternion(0, 0, 45, 0);
    public float speed = 2.0f;
    float yrotate;
    float zrotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");   //-45 ~ 45 y axis
        vertical = Input.GetAxis("Vertical");       //-30 ~ 30  z axis
        yrotate += horizontal * speed * Time.deltaTime;
        zrotate += vertical * speed * Time.deltaTime * -1;
        if (yrotate > 45)
        {
            yrotate = 45;
        }
        if(yrotate < -45)
        {
            yrotate = -45;
        }
        if(zrotate > 30)
        {
            zrotate = 30;
        }
        if(zrotate < -30)
        {
            zrotate = -30;
        }
        transform.rotation = Quaternion.Euler(0,yrotate, zrotate);
    }
}
