using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_spawner : MonoBehaviour
{

    public GameObject zombie;
    public Transform zombieSpawn;
    private bool lvl =false;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(zombie, zombieSpawn.position, zombieSpawn.rotation);
        Destroy(GameObject.FindGameObjectWithTag("HockeyZombie"));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lvl == false)
        {
            if(PlayerController.score>=5640)
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 0, 0);
                Instantiate(zombie, zombieSpawn.position, zombieSpawn.rotation);              
                lvl = true; 
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Purple"));
            }

            

        }
    }


}
