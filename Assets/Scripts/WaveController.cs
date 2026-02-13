using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Transform[] spawnPoints;

    private Wave wave;
    private int spawnedEnemies = 0;
    private float nextSpawntime = 0;

    public void ChangeWave(Wave wave)
    {
        this.wave = wave;
        spawnedEnemies = 0;
        nextSpawntime = Time.time;
    }
    public bool IsCompleted()
    {
        return spawnedEnemies >= wave.enemyCount;
    }
   
    void Update()
    {
        float t = Time.time;

        if (spawnedEnemies < wave.enemyCount && t > nextSpawntime)
        {
            Spawn();
            spawnedEnemies++;
            nextSpawntime = t + wave.spawnInterval;
        }
    }

    void Spawn()
    {
        int enemyIndex = Random.Range(0, wave.enemyprefabs.Length);
        int pointIndex = Random.Range(0, spawnPoints.Length);

        var prefab = wave.enemyprefabs[enemyIndex];
        var point = spawnPoints[pointIndex];

        Instantiate(prefab, point.position, Quaternion.Euler(0, 180, 0));
    }
}
