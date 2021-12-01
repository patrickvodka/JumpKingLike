using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBonus : MonoBehaviour
{
    [SerializeField] GameObject[] Bonus;

    [SerializeField] float Time;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(SpawnBonus());
    }
    IEnumerator SpawnBonus()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(Bonus[Random.Range(0, Bonus.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(Time);
            Destroy(gameObject, 5f);
        }
    }
    
}
