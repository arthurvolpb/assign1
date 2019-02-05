using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class explode : MonoBehaviour
{

    // Use this for initialization

    [SerializeField] private Image customImage;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider Cube)
    {


      
        Destroy(Cube.gameObject);

        GameObject House;
        House = GameObject.Find("House");
        Destroy(House.gameObject);

        GameObject SpartanKing;
        SpartanKing = GameObject.Find("SpartanKing");
        Destroy(SpartanKing.gameObject);

        //GameObject explosion;
        //explosion = GameObject.Find("explosion");
        //Destroy(explosion.gameObject);
        //explosion.SetActive(true);
        //customImage.enabled = true;

        Destroy(this.gameObject);


    }



}
