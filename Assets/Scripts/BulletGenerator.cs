using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject BulletPrefeb;
    public GameObject player;
    public Vector3 ScreenCenter;
    private OVRGrabbable ovrGrabbable;

    void Awake()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
            Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            Vector3 shooting = ray.direction;
            shooting = shooting.normalized;

            GameObject bullet = Instantiate(BulletPrefeb) as GameObject;
            bullet.transform.position = Camera.main.transform.position + shooting;
            bullet.GetComponent<BulletController>().Shoot(shooting * 2000);

            Destroy(bullet, 3f);
        }*/

        if (OVRInput.GetDown(OVRInput.RawButton.A) || ovrGrabbable.isGrabbed){

            Vector3 shooting = this.transform.forward;
            shooting = shooting.normalized;

            GameObject bullet = Instantiate(BulletPrefeb) as GameObject;
            bullet.transform.position = this.transform.position + shooting;
            bullet.GetComponent<BulletController>().Shoot(shooting * 2000);

            Destroy(bullet, 3f);
        }
    }
}
