using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    public float MoveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.UpArrow);
        bool isPressingDown = Input.GetKey(KeyCode.DownArrow);
        if (isPressingUp && this.transform.position.y < 3.5f)
        {
            transform.Translate(Vector2.up * Time.deltaTime * MoveSpeed);
        }

        if (isPressingDown && this.transform.position.y > -3.5f)
        {
            transform.Translate(Vector2.down * Time.deltaTime * MoveSpeed);
        }
    
    }
}
