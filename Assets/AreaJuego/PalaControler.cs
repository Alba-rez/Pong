using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palaControler : MonoBehaviour
{
    const float MAX_Y = 4.2f;
    const float MIN_Y = -4.2f;
    [SerializeField] float speed = 9.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Pala2"))
        {
            if (Input.GetKey("up") && transform.position.y < MAX_Y)
            {
                //transform.Translate(new Vector3(0, 0.1f, 0));
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey("down") && transform.position.y > MIN_Y)
            {
                //transform.Translate(new Vector3(0, -0.1f, 0));
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
        else if (gameObject.CompareTag("Pala1"))
        {
            if (Input.GetKey("w") && transform.position.y < MAX_Y)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey("s") && transform.position.y > MIN_Y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
