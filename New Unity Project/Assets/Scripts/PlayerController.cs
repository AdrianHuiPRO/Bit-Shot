using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 0.000000005f;
    public float FiringSpeed = 1f;
    public float RateOfFire = 0.25f;

    //private float rotationSpeed = 1f;
    public int HP = 3; 

    public KeyCode Right = KeyCode.RightArrow;
    public KeyCode Left = KeyCode.LeftArrow;
    public KeyCode Forward = KeyCode.UpArrow;
    public KeyCode Back = KeyCode.DownArrow;
    public KeyCode Shoot;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    {
        //Simple movement, still needs work
        if(Input.GetKey(Right))
        {
            transform.position += Vector3.right * MovementSpeed;
        }
        if(Input.GetKey(Left))
        {
            transform.position += Vector3.left * MovementSpeed;
        }
        if(Input.GetKey(Forward))
        {
            transform.position += Vector3.forward * MovementSpeed;
        }
        if(Input.GetKey(Back))
        {
            transform.position += Vector3.back;
        }
    }

    private void Rotation()
    {
        //Rotate Player based on where the mouse is relative to where it is on screen.
        Plane plane = new Plane(Vector3.up, 0);

        float distance;

        var tempPos = transform.position.y; 

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(plane.Raycast(ray, out distance))
        {
            //rotate on y axis based on where the mouse is relative to the screen
            
        }
    }

    public void Shooting()
    {
        //Fire Laser that do one point of damage
    }
}
