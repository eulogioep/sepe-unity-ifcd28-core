using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb2D;

    [SerializeField]
    float enemyVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb2D.velocity = new Vector2(enemyVelocity, 0);
    }

}
