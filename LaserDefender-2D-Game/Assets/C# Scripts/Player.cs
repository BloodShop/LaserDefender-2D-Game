using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Vector2 rawInput; // So we can update our position

    [SerializeField] float paddingLeft;
    [SerializeField] float paddingRight;
    [SerializeField] float paddingTop;
    [SerializeField] float paddingBottom;
    Vector2 minBounds; // store the vector2 for the bottom left of the viewPort at (0,0)
    Vector2 maxBounds; // store the vector2 for the top lerightft of the viewPort at (1,1)

    Shooter shooter;
    
    private void Awake() 
    {
        shooter = GetComponent<Shooter>();
    }

    void Start() 
    {
        InitBounds();
    }

    void Update()
    {
        Move();
    }

    void InitBounds() 
    {
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0,0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1,1));
    }

    void Move() 
    {
        Vector2 delta = rawInput * moveSpeed * Time.deltaTime;
        Vector2 newPosition = new Vector2();
        newPosition.x = Mathf.Clamp(transform.position.x + delta.x, minBounds.x + paddingLeft, maxBounds.x - paddingRight);
        newPosition.y = Mathf.Clamp(transform.position.y + delta.y, minBounds.y + paddingBottom, maxBounds.y - paddingTop);
        transform.position = newPosition;
    }

    void OnMove(InputValue value) 
    {
        rawInput = value.Get<Vector2>();
    }

    void OnFire(InputValue value)
    {
        if(shooter != null)
        {
            shooter.isFiring = value.isPressed;
        }
    }
}
