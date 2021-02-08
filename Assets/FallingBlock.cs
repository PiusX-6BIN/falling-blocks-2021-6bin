using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{

    [SerializeField]
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float input = -1f * Time.deltaTime * speed;

        Vector3 beweging = new Vector3(0, input, 0);

        this.transform.Translate(beweging);
    }
}
