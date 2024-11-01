using UnityEngine;

public class PlayerCrosshair : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}

