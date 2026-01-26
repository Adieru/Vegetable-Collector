using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    public int score = 10;


    public float TmDeath = .5f;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject, TmDeath);
        }
    }


}
