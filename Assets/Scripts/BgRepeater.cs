using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRepeater : MonoBehaviour
{
    Vector3 startPos;
    float repeatWidth;
    float repeatHeight;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
        repeatHeight = GetComponent<BoxCollider2D>().size.y / 2;
    }

    void Update()
    {
        // Check for horizontal wrap
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = new Vector3(startPos.x + repeatWidth, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > startPos.x + repeatWidth)
        {
            transform.position = new Vector3(startPos.x - repeatWidth, transform.position.y, transform.position.z);
        }

        // Check for vertical wrap
        if (transform.position.y < startPos.y - repeatHeight)
        {
            transform.position = new Vector3(transform.position.x, startPos.y + repeatHeight, transform.position.z);
        }
        else if (transform.position.y > startPos.y + repeatHeight)
        {
            transform.position = new Vector3(transform.position.x, startPos.y - repeatHeight, transform.position.z);
        }
    }
}