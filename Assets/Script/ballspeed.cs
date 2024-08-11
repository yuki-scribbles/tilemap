using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballspeed : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] private int maxSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = rb.velocity;

        if(vel.x > maxSpeed) {
            vel.x = maxSpeed;
        }
        if(vel.y > maxSpeed) { vel.y = maxSpeed;}
    }
}
