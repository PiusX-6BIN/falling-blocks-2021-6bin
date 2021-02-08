using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 2f;

    float xRand = 0f;

    // Start is called before the first frame update
    void Start()
    {
        float schermHoogte = Camera.main.orthographicSize * 2f;

        float aspectRatio = Camera.main.aspect;

        float schermBreedte = schermHoogte * aspectRatio;

        xRand = schermBreedte / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        Vector3 beweging = new Vector3(input, 0, 0);

        this.transform.Translate(beweging);

        if (this.transform.position.x > xRand)
        {
            this.transform.position = new Vector3(-xRand,
                                                    this.transform.position.y,
                                                    this.transform.position.z);
        }
        else if (this.transform.position.x < -xRand)
        {
            this.transform.position = new Vector3(xRand,
                                                    this.transform.position.y,
                                                    this.transform.position.z);
        }
    }
}
