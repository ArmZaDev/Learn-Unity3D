using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{

    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip itemSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Item") //tag.Equals("Item")
        {
            //Delete Item in Scene game
            Destroy(target.gameObject);
            score += 10;
            scoreText.text = "Score X " + score.ToString();

            audioSource.PlayOneShot(itemSource);
        }
    }


}
