using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    public float TmDeath = 5f;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject, TmDeath);
        }
    }


}
