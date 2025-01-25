using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform particleSpawnPosition;
    [SerializeField] ParticleSystem hoopParticles;

    [SerializeField] GameObject finalScoreUI;
    
    TextMeshProUGUI finalScoreText;

    void Start()
    {
        score = 0;
        scoreText.text = "0";
        finalScoreText = finalScoreUI.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        finalScoreText.text = score.ToString();
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
