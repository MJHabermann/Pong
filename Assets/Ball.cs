using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class script : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;
        float xVelocity = -1f;
        rb = GetComponent<Rigidbody2D>();
        if(isRight == true)
        {
            xVelocity = 1f;
        }
        float yVelocity = UnityEngine.Random.Range(-100,100);
        yVelocity = yVelocity / 100;
        rb.velocity = new Vector2(xVelocity * startingSpeed,yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
    { 
        if (this.transform.position.x <= -10f || this.transform.position.x >= 10f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            bool isRight = UnityEngine.Random.value >= 0.5;
            float xVelocity = -1f;
            if (isRight == true)
            {
                xVelocity = 1f;
            }
            float yVelocity = UnityEngine.Random.Range(-100, 100);
            yVelocity = yVelocity / 100;
            rb.velocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
        }
    }
}
