using UnityEngine;
public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] int nbObjects = 5;

    [SerializeField] Vector3 min;
    [SerializeField] Vector3 max;

    void Start()
    {
        for (int i = 0; i < nbObjects; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y,max.y), Random.Range(min.z, max.z));
            float r = Random.Range(0f, 180f);
            Instantiate(prefab, randomPos, Quaternion.Euler(0,r,0));
        }
    }

}