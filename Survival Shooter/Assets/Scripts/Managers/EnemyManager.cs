using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    [SerializeField] private MonoBehaviour factory;
    private IFactory Factory { get { return factory as IFactory; } }

    // [SerializeField] private EnemyFactory factory;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        int spawnEnemy = Random.Range (0, 3);

        GameObject enemy = Factory.FactoryMethod (spawnEnemy);
        enemy.transform.position = spawnPoints[spawnPointIndex].position;
        enemy.transform.rotation = spawnPoints[spawnPointIndex].rotation;
        //Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
