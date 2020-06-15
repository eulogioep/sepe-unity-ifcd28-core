using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    float parallaxVelocity;

    [SerializeField]
    bool stopParallax;

 
    // Update is called once per frame
    void Update()
    {
        MoveParallax();
    }

    void MoveParallax()
    {
        if (stopParallax == false)
        {
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(((Time.time) * parallaxVelocity), 0);
        }
    }
}
