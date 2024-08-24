using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public LogicMangScript logic;
    public GameObject Pipe;
    public float SRate = 3.5F;
    private float timer = 0;
    public float hightOffSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowepoint =transform.position.y - hightOffSet;
        float highepoint =transform.position.y + hightOffSet;


        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowepoint,highepoint),0), transform.rotation);
    }
}
