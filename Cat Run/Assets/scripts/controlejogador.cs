using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlejogador : MonoBehaviour
{
    
    public float VelocidadeAndar = 1f;
    private float velocidadeslide;
    public float fallforce = 150f;
    private float i = 2;
    private float j = 2;
    private bool Jump = false;
    public float Jumpforce = 200f;
    public Transform groundcheck;
    private bool ground = false;
    private bool pulo = false;
    private bool slide = false;

    private bool Slide = false;
    
    public Animator animator;
    public bool gameover;
    public CapsuleCollider2D regularcoll;
    public CapsuleCollider2D slidecoll;


    


      
      private void Start()
        {
            animator = transform.GetComponentInChildren<Animator>();
            //velocidadeslide = VelocidadeAndar;
        }
        void Update ()
        {
             if(gameover)
             {
                 UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
                 

             }

             velocidadeslide = VelocidadeAndar;
             velocidadecontrole();

                ground = Physics2D.Linecast(transform.position, groundcheck.position, 1 << LayerMask.NameToLayer("Ground"));
                animator.SetBool("onchao", ground);
            if(ground)
                {
                    animator.SetBool("pulo", false);
                    
                    
                }
               
            if( Input.GetKeyDown(KeyCode.Space))
                {
                    jump();
                 }

                 if(Input.GetKeyDown(KeyCode.F))
                 {
                     caidarapida();
                 }
            if(Input.GetKey(KeyCode.S))
                {
                    escorregar();
                }
                  if(!Input.GetKey(KeyCode.S))
                  {
                      stopslide();
                  }
                
        
                
        }

    void FixedUpdate()
    {   
        GetComponent<Rigidbody2D>().velocity = new Vector2(VelocidadeAndar, GetComponent<Rigidbody2D>().velocity.y);
        
         

    }       


      


    public void jump()
    {

        if(ground == true)
        {
            Jump = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Jumpforce));
            animator.SetBool("pulo", true);
            
            Jump = false;
           
            
            

        }
    }
        public void escorregar()
    {
        if(ground == true)
        {
            Slide = true;
            animator.SetBool("slide", true);

            slidecoll.enabled = true;
            regularcoll.enabled = false;
            
            GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidadeslide, 0));
            
            Slide = false;
        }
        

    }

        public void stopslide()
        {
            if(Slide == false)
            {
                animator.SetBool("slide", false);
                slidecoll.enabled = false;
                regularcoll.enabled = true; 
            }
        }
    private void OnTriggerEnter2D (Collider2D col)
    {
           if(col.CompareTag("aumentovelocidade"))
           {    
                VelocidadeAndar +=i;
           }
             if(col.CompareTag("veiculo"))
            {
                animator.SetTrigger("fim");
                gameover = true;
            }
    }     

      public void velocidadecontrole()
    {

        if(VelocidadeAndar >= 12)
        {

            VelocidadeAndar -=j;

        }

    }
    public void caidarapida()
    {
        
       GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fallforce));
      
    }
         
}
