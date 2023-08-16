using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    [SerializeField] GameObject[] prefabBall;
    [SerializeField] float spawnSpeed = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    void Start()
    {
        StartCoroutine(BallSpawn());
    }

    IEnumerator BallSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(prefabBall[Random.Range(0, prefabBall.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(spawnSpeed);
            Destroy(gameObject, 5f);
        }
    }

}
