using UnityEngine;
using System.Collections;


public class ball : MonoBehaviour
{
    public GameObject Ball; 
public void Shoot(Vector3 dir)
{
        GetComponent<Rigidbody>().AddForce(dir);
}
 void Start()
    {
    //    Shoot(new Vector3(0, 200, 2000));     

    }
     void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject Ball = Instantiate(BallP) as GameObject;

            Ray ray = camera.main.scrwwnpointToRay(Input.mousePosition);
            Ball.GetComponent<ball>().Shoot(worldDir.normalized * 2000);
        }
    }
}