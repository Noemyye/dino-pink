using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }

    private Player player;
    private Spawner spawner;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        // Utiliser FindFirstObjectByType pour récupérer un seul objet
        player = FindFirstObjectByType<Player>();
        spawner = FindFirstObjectByType<Spawner>();

        if (player == null || spawner == null)
        {
            Debug.LogError("Player ou Spawner introuvable dans la scène.");
            return;
        }

        NewGame();
    }

    private void NewGame()
    {
        // Utiliser FindObjectsByType pour récupérer tous les obstacles
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");


        foreach (var obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        gameSpeed = initialGameSpeed;
        enabled = true;

        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;

        player.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
    }
}
