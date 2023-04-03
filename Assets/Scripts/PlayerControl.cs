using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKeyDown(KeyCode.A))
        {
            newPos.x -= speed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newPos.x += speed;
        }

        Debug.Log(newPos.x);

        transform.position = newPos;
    }
}
