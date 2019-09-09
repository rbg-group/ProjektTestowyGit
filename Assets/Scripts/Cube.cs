using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Transform transform;

    void Awake()
    {
        transform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.anyKeyDown)
        {
            //transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);

            Vector3 currentScale = transform.localScale;

            Vector3 targetScale = new Vector3(2 * transform.localScale.x, 2 * transform.localScale.y, 2 * transform.localScale.z);

            transform.localScale = Vector3.Lerp(currentScale, targetScale, 1.0f);

            //currentScale = targetScale;
        }
    }
}