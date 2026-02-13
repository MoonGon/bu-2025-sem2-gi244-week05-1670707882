using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // [1] declare a public GameObject array for animal prefabs
    public GameObject[] animalPrefabs;
    // [2] declare a public int variable for animal index for testing instantiation
    private int animalIndex;
    public float spawnRangeX = 15;

    private void Start()
    {
        InvokeRepeating(nameof(spawnAnimal), 0.5f, 1f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawnAnimal();
        }
    }

    void spawnAnimal() 
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new(
                Random.Range(-spawnRangeX, spawnRangeX),
                transform.position.y,
                transform.position.z
            );

            Instantiate(
                animalPrefabs[animalIndex],
                spawnPos,
                animalPrefabs[animalIndex].transform.rotation
            );

    }
}
