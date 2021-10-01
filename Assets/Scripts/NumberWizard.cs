using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int max = 1000;
    [SerializeField] private int min = 1;
    [SerializeField] private TextMeshProUGUI guessText;
    
    private int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        max = max + 1;
        this.UpdateGuess();
    }

    public void OnPressHigher()
    {
        min = guess;
        this.UpdateGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        this.UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = Random.Range(min, max);
        guessText.SetText(guess.ToString());
    }
}
