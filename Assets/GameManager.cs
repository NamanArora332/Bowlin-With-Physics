using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
[SerializeField] private float score = 0;
private FallTrigger[] pins;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
{
        
        
        pins = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include, FindObjectsSortMode.None);


        
        
        foreach (FallTrigger pin in pins)
{
pin.OnPinFall.AddListener(IncrementScore);
}
}

private void IncrementScore()
{
score++;
        scoreText.text = $"Score: {score}";
    }
}