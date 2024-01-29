using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{


    Animator _animator;
   

    public float speed = 2.5f;
    private Vector3 originalScale;
    
 

    private void Start()
    {
        originalScale = transform.localScale;

        

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        movement.Normalize();
        FlipCharacter(horizontalInput);
        transform.Translate(movement * speed * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
           
        }

        
        if (horizontalInput > 0)
        {

        }
      


      
    }

    private void FlipCharacter(float horizontalInput)
    {
        if (horizontalInput > 0)
        {
            
            transform.localScale = originalScale;
        }
        else if (horizontalInput < 0)
        {
            
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
        

    }
}
