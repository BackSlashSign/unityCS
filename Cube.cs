using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    Vector3 positionRandomFloat;
    public Material material;

    float sign = 1.0f;
    public float colorCurvFloat = 0.5f;
    public float colorRangeR = 0.01f;


    void Start()
    {

        positionRandomFloat = new Vector3(
            Random.Range(1.0f, 2.0f), Random.Range(1.0f, 2.0f), Random.Range(1.0f, 2.0f));
        
        transform.position = positionRandomFloat;
        transform.localScale = Vector3.one * Random.Range(0.3f,1.0f);
        
        material = Renderer.material;
    }
    
    void FixedUpdate()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        //material.color = new Color(colorRangeR + (colorCurvFloat * sign), 0,0);
        material.color = new Color(colorRangeR, 0, 0);
        if (colorRangeR >= 1)
        {
            sign = -1.0f;
        }
        else if(colorRangeR <= 0)
        {
            sign = 1.0f;
        }
        colorRangeR += (Time.deltaTime * sign * colorCurvFloat);
        //Debug.Log("colorRangeR " + colorRangeR);
        //Debug.Log(Time.deltaTime * 10);
    }
}
