using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] int delayTime;

    SpawnBall spawnBall;
    Collider otherCollider;


    void Start()
    {
        spawnBall = FindFirstObjectByType<SpawnBall>();
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            otherCollider = other.gameObject.GetComponent<Collider>();
            score++;
            
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Ball"))
    //    {
    //        Invoke(nameof(BallSpawnDelayer), delayTime);   
    //    }
    //}

    //void BallSpawnDelayer()
    //{
    //    Destroy(otherCollider.gameObject);
    //    spawnBall.SpawnBasketBall();
    //}
}
