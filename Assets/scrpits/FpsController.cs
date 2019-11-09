
using UnityEngine;

public class FpsController : MonoBehaviour
{

    public GameObject camerasParent;
    public float walkSpeed = 5f;
    public float hRotationSpeed = 100f;
    public float vRotationSpeed = 80f;


    void Start()
    {

        //Esconde y bloquea el ratón
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        movement();
       

    }
    private void movement() { 
    //movimiento personaje  
    float hMovement = Input.GetAxisRaw("Horizontal");
    float vMovement = Input.GetAxisRaw("Vertical");

    Vector3 movementDirection = hMovement * Vector3.right + vMovement * Vector3.forward;
    transform.Translate(movementDirection* (walkSpeed* Time.deltaTime));

        //Rotacion
        float vCamRotation = Input.GetAxis("Mouse Y") * vRotationSpeed * Time.deltaTime;
    float hPlayerRotation = Input.GetAxis("Mouse X") * hRotationSpeed * Time.deltaTime;

    transform.Rotate(0f, hPlayerRotation, 0f);
        camerasParent.transform.Rotate(-vCamRotation, 0f, 0f);
    }

    }