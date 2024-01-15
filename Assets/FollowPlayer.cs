using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0f, 2f, 0f);
    public Text speechText;

    private float speechInterval = 15f;

    void Start()
    {
        StartCoroutine(RandomSpeech());
    }

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 reversedOffset = new Vector3(-offset.x, offset.y, offset.z);
            transform.position = playerTransform.position + reversedOffset;
            float playerRotation = playerTransform.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, playerRotation, 0f);
        }
    }

    IEnumerator RandomSpeech()
    {
        while (true)
        {
            yield return new WaitForSeconds(speechInterval);
            SaySomethingRandom();
        }
    }

    void SaySomethingRandom()
    {
        if (speechText != null)
        {
            string[] randomSpeeches = { "Hello!", "How are you?", "I'm following you!", "Random speech!" };
            string randomSpeech = randomSpeeches[Random.Range(0, randomSpeeches.Length)];
            speechText.text = randomSpeech;
        }
    }
}
