using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] GameObject basketBall;

    public void SpawnBasketBall()
    {
        Instantiate(basketBall, transform.position, Quaternion.identity);
    }
}
