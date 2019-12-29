using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{

    public Transform playerTransform;
    public float speed;

    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(playerTransform != null)
        {
            float boundX = Mathf.Clamp(playerTransform.position.x, minX, maxX);
            float boundY = Mathf.Clamp(playerTransform.position.y, minY, maxY);

            transform.position = Vector2.Lerp(transform.position, new Vector2(boundX, boundY), speed);
        }


    }
}
