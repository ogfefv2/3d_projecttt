using System.Collections;
using UnityEngine;

public class CouroutineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Coroutine _spawnCor;

    void Start()
    {

        _spawnCor = StartCoroutine(routine: SpawnCourutine());
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            StopCoroutine(_spawnCor);
        }
    }


    public IEnumerator SpawnCourutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }

        
    }
}
