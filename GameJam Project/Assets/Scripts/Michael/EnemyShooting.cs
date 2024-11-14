using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Bulletpos;


    private float timer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);// distenace from enemy to player
        Debug.Lod(distance);


        if (distance < 5)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();

            }


        }

    }

    void shoot()
    {
        Instantiate(Bullet, Bulletpos.position, Quaternion.identity);
    }

}   
