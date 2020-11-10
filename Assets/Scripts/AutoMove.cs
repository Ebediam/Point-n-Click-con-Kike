
using UnityEngine;

// 2D MoveTowards example
// Move the sprite to where the mouse is clicked
//
// Set speed to -1.0f and the sprite will move
// away from the mouse click position forever

public class AutoMove : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector2 target;
    private Vector2 position;
    private Camera cam;

    void Start()
    {
        target = new Vector2(-3.0f, -0.2f);
        position = gameObject.transform.position;

        cam = Camera.main;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
}