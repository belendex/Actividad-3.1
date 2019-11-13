
using UnityEngine;

public class FpsController : MonoBehaviour
{

    public GameObject camerasParent;
    public GameObject FPSCAMERA;
    public float walkSpeed = 4f;
    public float hRotationSpeed = 100f;
    public float vRotationSpeed = 80f;
    public float sprintSpeed = 10f;

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
          sprint();
         if (Input.GetKey(KeyCode.C))

         {
            camerasParent.transform.Translate(0, -0.04f, 0);
           
        }
       
    }
    
       
       
        
    private void movement() {
        //movimiento personaje  
        float hMovement = Input.GetAxisRaw("Horizontal");
        float vMovement = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = hMovement * Vector3.right + vMovement * Vector3.forward;
        transform.Translate(movementDirection * (walkSpeed * Time.deltaTime));

        //Rotacion
        float vCamRotation = Input.GetAxis("Mouse Y") * vRotationSpeed * Time.deltaTime;
        float hPlayerRotation = Input.GetAxis("Mouse X") * hRotationSpeed * Time.deltaTime;

        transform.Rotate(0f, hPlayerRotation, 0f);
        camerasParent.transform.Rotate(-vCamRotation, 0f, 0f);
    }
    private void sprint()
    {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walkSpeed = sprintSpeed;
            }
            else
            {
                walkSpeed = 4f;
            }


        }
    }

