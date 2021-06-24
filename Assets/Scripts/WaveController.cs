using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveController : MonoBehaviour
{
    //public Transform enemy;
    List<Enemy> enemies = new List<Enemy>();

    public float timeBetweenWaves = 5f;
    public float countDown = 3f;
    //private List<Transform> enemies = new List<Transform>();
    private int waveIndex = 0;
    public Image CountdownCircle;
    public Text CountdownText;

    enum spawnState
    {
        SPAWNING,
        WAITING,
        COUNTING
    }
    spawnState state;

    private void Start()
    {
        StartCoroutine(RunSpawner());
    }

    // this replaces your Update method
    private IEnumerator RunSpawner()
    {
        // first time wait 2 seconds
        yield return new WaitForSeconds(countDown);

        //// run this routine infinite
        while (true)
        {
            state = spawnState.SPAWNING;

            // do the spawning and at the same time wait until it's finished
            yield return SpawnWave();

            state = spawnState.WAITING;

            // wait until all enemies died (are destroyed)
            yield return new WaitWhile(EnemyisAlive);

            state = spawnState.COUNTING;

            // wait 5 seconds
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }

    private bool EnemyisAlive()
    {
        // uses Linq to filter out null (previously detroyed) entries
        enemies = enemies.Where(e => e != null).ToList();

        return enemies.Count > 0;
    }

    private IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void SpawnEnemy()
    {
        //enemies.Add(Instantiate(enemy, transform.position, transform.rotation));
    }
}