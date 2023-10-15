using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public int numberOfCoinsToSpawn = 10;
    public Vector3 spawnRegion = new Vector3(10, 0, 10);
    void Start()
    { 
            for (int i = 0; i < numberOfCoinsToSpawn; i++)
            {
                SpawnCoin();
            }    
    }
    
   
    void SpawnCoin()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnRegion.x, spawnRegion.x),
            0.5f, 
            Random.Range(-spawnRegion.z, spawnRegion.z)
        );

       
        if (!IsPositionOccupied(randomPosition))
        {
            Instantiate(coinPrefab, randomPosition, Quaternion.identity);
        }
        else
        {
            
            SpawnCoin();
        }
    }
    bool IsPositionOccupied(Vector3 position)
    {
        Collider[] colliders = Physics.OverlapSphere(position, 3f); 

        foreach (var collider in colliders)
        {
            
            if (collider.gameObject.layer == LayerMask.NameToLayer("Obstacles"))
            {
                return true; 
            }
        }

        return false; 
    }
}
