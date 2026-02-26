using UnityEngine;

public class IconBehaviour : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // add delay to the rotation so they don't all rotate in sync
        float delay = Random.Range(0f, 2f);
        if (Time.time % 2f < delay)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }
    }
}
