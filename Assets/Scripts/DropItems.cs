using System.Collections;
using UnityEngine;

public class DropItems : MonoBehaviour
{
    public Transform[] Droppers;

    public GameObject[] Fregetable;

    public GameObject Bomb;

    public GameObject Holder;

    [SerializeField] float SpawnTime = 3;
    float timer;

    [SerializeField] float bombTime = 5;
    float bombTimer;

    int DropperSize;
    int FruitSize;

    private void Start()
    {
        //Timer
        timer = SpawnTime;
        bombTimer = bombTime;

        //Size of the holders
        DropperSize = Droppers.Length;
        FruitSize = Fregetable.Length;

    }

    private void Update()
    {
        timer -= Time.deltaTime;
        bombTimer -= Time.deltaTime;

        //Spawn
        RandomSpawn();

    }

    //Spawn Fruit
    void spawnFruits(int time)
    { 
        if(time <= 0)
        {
            int DropIndex = Random.Range(0, DropperSize);

            int FruitIndex = Random.Range(0, FruitSize);

            //Spawn
            GameObject spawnObj = Instantiate(Fregetable[FruitIndex], Holder.transform);

            spawnObj.transform.position = Droppers[DropIndex].position;

            //Reset time
            timer = SpawnTime;

        }
    }

    //Spawn Bomb
    void spawnBomb(int time)
    {
        if(time <= 0)
        {
            int DropIndex = Random.Range(0, DropperSize);

            //Spawn
            GameObject spawnObj = Instantiate(Bomb, Holder.transform);
            spawnObj.transform.position = Droppers[DropIndex].position;

            //Reset timer
            bombTimer = bombTime;

        }
    }

    //Random Spawner
    void RandomSpawn()
    {
        //Random Spawn
        int spawnNum = Random.Range(1, 10);

        switch (spawnNum)
        {
       
            //Bomb
            case 1:
            case 2:
            case 3:
                spawnBomb((int)bombTimer);
                break;



            //fruit
            default:
                spawnFruits((int)timer);
                break;
        }

    }

}
