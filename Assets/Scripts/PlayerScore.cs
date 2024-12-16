using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerScore : MonoBehaviour
{
    public float score;
    public TMP_Text scoreText;
    public AudioClip scoreAudio;

    private void Update()
    {
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreTrigger"))
        {
            score++;
            GetComponent<AudioSource>().PlayOneShot(scoreAudio, 1f);
        }
    }
}
