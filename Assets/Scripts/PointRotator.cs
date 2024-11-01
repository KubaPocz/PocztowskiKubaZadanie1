using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 0.3f, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (gameObject.tag != "Point")
            {
                Renderer objectRenderer = GetComponent<Renderer>();
                objectRenderer.material.color = Color.red;
            }
        }
    }
}
