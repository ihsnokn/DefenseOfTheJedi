using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{

    public float walkSpeed;

    [HideInInspector]
    public bool mustPatrol;
    public Rigidbody2D rb;
    void Start()
    {
        mustPatrol = true;
    }
    void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
