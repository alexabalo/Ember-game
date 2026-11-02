using UnityEngine;

public class Movimientos : MonoBehaviour
{

    Animator animator;
    private int movimientoHorizontal = 0;
    private int movimientoVertical = 0;

    private Vector2 mov = Vector2.zero;

    [SerializeField] private float velocidadNormal = 5f;
    [SerializeField] private float velocidadSprint = 10f;

    private float velocidadActual;

    private Rigidbody2D rb;

    public int fireObtenido;

    void Start()
    {

        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
        velocidadActual = velocidadNormal;
    }


 

    private bool giroIzq = false;

    private void FlipSprite()
    {
        if(rb.linearVelocity.x < 0 && !giroIzq)
        {
            giroIzq = true;

            Vector3 ls = transform.localScale;
            ls.x *= -1;
            transform.localScale = ls;
        }
        else if (rb.linearVelocity.x > 0 && giroIzq)
        {
            giroIzq = false;

            Vector3 ls = transform.localScale;
            ls.x *= -1;
            transform.localScale = ls;
        }
    }





    private void Attack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
    }

    void Update()


    {

        //ataque click izquierdo
        Attack();

        //giro personaje
        FlipSprite();



        //animacion de movimiento
        if (Mathf.Abs(mov.x) > 0 || Mathf.Abs(mov.y) > 0)
        {
            animator.SetFloat("xVelocity", 1);
        }
        else
        {
            animator.SetFloat("xVelocity", 0);
        }


        // Movimiento vertical

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("ESTOY APRETANDO W");

            movimientoVertical = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movimientoVertical = -1;
        }
        else
        {
            movimientoVertical = 0;
        }

        // Movimiento horizontal
        if (Input.GetKey(KeyCode.D))
        {
            movimientoHorizontal = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movimientoHorizontal = -1;
        }
        else
        {
            movimientoHorizontal = 0;
        }

        // Vector de movimiento
        mov = new Vector2(movimientoHorizontal, movimientoVertical);
        mov = mov.normalized;

        // Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidadActual = velocidadSprint;
        }
        else
        {
            velocidadActual = velocidadNormal;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = mov * velocidadActual;
    }
}