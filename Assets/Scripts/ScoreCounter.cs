using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform particleSpawnPosition;
    [SerializeField] ParticleSystem hoopParticles;

    GameObject finalScoreUI;
    TextMeshProUGUI finalScoreText;

    void Start()
    {
        score = 0;
        scoreText.text = "0";
    }

    private void Update()
    {
        if(finalScoreUI == null)
        {
            finalScoreUI = GameObject.FindGameObjectWithTag("FinalScoreUI");
            finalScoreText = finalScoreUI.GetComponent<TextMeshProUGUI>();
        }
        else if(finalScoreUI != null) 
        {
            finalScoreText.text = score.ToString();
        }
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
