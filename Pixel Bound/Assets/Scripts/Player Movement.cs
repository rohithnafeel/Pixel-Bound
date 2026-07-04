using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Going Right");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Going Left");
        }
    }
}
