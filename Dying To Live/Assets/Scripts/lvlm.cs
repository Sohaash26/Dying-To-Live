using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlm : MonoBehaviour
{
    public GameObject chkpnt;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void respwan()
    {
        FindObjectOfType<char_mov>().transform.position = chkpnt.transform.position;
    }
    public void SpawnEnemy()
    {
        Instantiate(enemy,transform.position,transform.rotation);
    }
}
