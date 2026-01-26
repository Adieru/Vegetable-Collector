using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Score
    [SerializeField] TextMeshProUGUI scoreText;

    //Fruit Value
    int fruitVal = 0;


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

            //Sound Effect
            
            //Game Over
            Debug.Log("Game Over!");
        }
    }


}
