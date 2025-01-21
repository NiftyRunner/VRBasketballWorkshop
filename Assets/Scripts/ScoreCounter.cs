using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform particleSpawnPosition;
    [SerializeField] ParticleSystem hoopParticles;

    void Start()
    {
        score = 0;
        scoreText.text = "0";
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Instantiate(hoopParticles, particleSpawnPosition);
            score++;
            scoreText.text = score.ToString();
        }
    }
}
