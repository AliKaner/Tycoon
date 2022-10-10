using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] 
    private Vector3 moveVector;
    
    private Animator _animator;
    public float speed;
    
    private Rigidbody _rb;
    private static readonly int WalkingSpeed = Animator.StringToHash("WalkingSpeed");

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _rb.velocity = moveVector;
        speed = moveVector.magnitude;
        
       // Debug.Log($"Speed: {speed}");
        
        
        //controlls

        var input = Input.inputString;
        
        if (!string.IsNullOrEmpty(input))
        {
            switch (input)
            {
                case "w":
                    SetVelocity("x",.25f);
                    break;
                case "a":
                    SetVelocity("z",.25f);
                    break;
                case "d":
                    SetVelocity("z",-.25f);
                    break;
                case "s":
                    SetVelocity("x",-.25f);
                    break;
                case "space":
                    break;
            }
        }

    }

    public void SetVelocity(string direction,float amount)
    {
        var newMoveVector = moveVector;

        switch (direction)
        {
            case "x":
                newMoveVector.x += amount;
                break;
            case "y":
                newMoveVector.y += amount;
                break;
            case "z":
                newMoveVector.z += amount;
                break;

        }
        Debug.Log($" direction is :{direction} amount is {amount}");
        moveVector = newMoveVector;
        
        _animator.SetFloat(WalkingSpeed,speed);
    }
    
    
}
