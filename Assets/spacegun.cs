using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacegun : MonoBehaviour
{
    public float playerSpeed;
    public float minX, minY, maxX, maxY;
    public GameObject laserBeam;
    public GameObject laserBeamSpawner;
    public float fireRate = 0.25f;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horMove;
        float vertMove;
        horMove = Input.GetAxis("Horizontal");
        vertMove = Input.GetAxis("Vertical");

        //Debug.Log("H: " +  horMove + " , V: " +  vertMove);

        Vector2 newVelocity = new Vector2(horMove, vertMove);
        GetComponent<Rigidbody2D>().velocity = newVelocity * playerSpeed;


        float newX, newY;
        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);

        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);

        if (Input.GetAxis("Fire 1") > 0 && timer > fireRate)
        {
            GameObject goObj;
            goObj = GameObject.Instantiate(laserBeam, laserBeamSpawner.transform.position, laserBeamSpawner.transform.rotation);
            goObj.transform.Rotate(0.0f, 0.0f, -90.0f);

            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
