using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    NavMeshAgent _agent;
    Animator _animator;
   

    public float speed = 2.5f;
    private Vector3 originalScale;
    
 

    private void Start()
    {
        originalScale = transform.localScale;

        _animator = GetComponentInChildren<Animator>();
        _agent = GetComponent<NavMeshAgent>();

        

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
      


        float speedPercent = _agent.velocity.magnitude / _agent.speed;
        _animator.SetFloat("speed", speedPercent);
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
