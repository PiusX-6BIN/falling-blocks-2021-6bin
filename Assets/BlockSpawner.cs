using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject blockPrefab;

    float timer = 0f;

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
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            float xPosition = Random.Range(-xRand, xRand);
            Vector3 position = new Vector3(xPosition, Camera.main.orthographicSize * 2, 0);

            // random rotation
            //Quaternion.AngleAxis (hoek, new Vector3(0, 0, 1));

            // random size
            //blockPrefab.transform.localScale

            Instantiate(blockPrefab, position, this.transform.rotation);
            timer = 0f;
        }
    }
}
