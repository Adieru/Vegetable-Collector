using UnityEngine;

public class DropItems : MonoBehaviour
{
    public Transform[] Droppers;

    public GameObject[] Fregetable;

    public GameObject Holder;

    float SpawnTime = 3;

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
            SpawnTime = 3;

        }
    }

}
