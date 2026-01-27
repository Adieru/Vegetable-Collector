using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    //Score
    [SerializeField] TextMeshProUGUI scoreText;

    //GameOver panel
    [SerializeField] GameObject gameOverPanel;

    //Fruit Value
    int fruitVal = 0;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Food"))
        {
            //Get score from ItemManager script
             fruitVal += other.gameObject.GetComponent<ItemManager>().score;

            //Update score text
            scoreText.text = "Score: " + fruitVal.ToString();


            Destroy(other.gameObject, 0.1f);
        }

        //Bomb
        else if(other.gameObject.CompareTag("Bomb"))
        {

            //Animation
            other.GetComponentInChildren<ParticleSystem>().Play();

            //Sound Effect

            //Game Over
            StartCoroutine(GameOver());



        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);

        gameOverPanel.SetActive(true);

        //Stop time 
        Time.timeScale = 0f;


    }



}
