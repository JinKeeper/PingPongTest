using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RocketsController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Vector3 direction;
    private Rigidbody2D rigidBody;
    private Vector3 touchPosition;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rigidBody.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if (touch.phase == TouchPhase.Ended) 
            rigidBody.velocity = Vector2.zero;
            
        }
    }
}
