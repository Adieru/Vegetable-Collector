using UnityEngine;

public class DropItems : MonoBehaviour
{
    public Transform[] Droppers;

    public GameObject[] Fregetable;

    public GameObject Holder;

    [SerializeField] float SpawnTime = 3;
    float timer;

    private void Start()
    {
        timer = SpawnTime;
    }

    private void Update()
    {
        SpawnTime -= Time.deltaTime;

        spawnFruits((int)SpawnTime);


    }

    void spawnFruits(int time)
    { 
        if(time <= 0)
        {
            int DropIndex = Random.Range(0, Droppers.Length);

            int FruitIndex = Random.Range(0, Fregetable.Length);

            GameObject spawnObj = Instantiate(Fregetable[FruitIndex], Holder.transform);

            spawnObj.transform.position = Droppers[DropIndex].position;

            //Reset time
            SpawnTime = timer;

        }
    }

}
