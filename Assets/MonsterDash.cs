using UnityEngine;

public class MonsterDash : MonoBehaviour
{
    public Transform targetPosition;
    public float speed = 5f;

    private bool isTriggered = false;

    void Update()
    {
        if (isTriggered)
        {
            Debug.Log("Moving towards target position");
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player triggered the movement");
            isTriggered = true;
        }
    }
}
