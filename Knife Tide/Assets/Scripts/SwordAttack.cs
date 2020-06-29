using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwordAttack : MonoBehaviour
{

    public GameObject swordObject, arrow, gameController, scoreController;

    [HideInInspector] public bool grounded;

    public Animator swordAnimator;

    [HideInInspector] public bool gameIsOver;
    public float upforce;
    public AudioSource swordAttackSound, swordImpactSound;



    private void Start()
    {

        grounded = true;
        gameIsOver = false;
    }
    private void Update()
    {
        //Debug.Log(arrow.transform.localEulerAngles.z);



        swordAnimator.SetBool("Grounded", grounded);


        // if (transform.position.x < 1 && transform.position.x > -1)
        //  {
        //  gameObject.GetComponent<BoxCollider2D>().enabled = true;

        //   }


        if (grounded)
        {
            // gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);

        }






    }
    public void SwordAttackFunction()
    {

        //  if ((Input.touchCount > 0 || Input.GetKeyDown("space")) && grounded)
        //  if (Input.GetKeyDown("space") && grounded)
        if (grounded)
        {
            swordObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

            arrow.GetComponent<SpriteRenderer>().enabled = false;

            swordAttackSound.Play();
            grounded = false;
            if (transform.position.x > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, (arrow.transform.localEulerAngles.z - 360 + 90f));
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, -(arrow.transform.localEulerAngles.z - 360 + 90f));
            }


            swordObject.GetComponent<Rigidbody2D>().AddForce(transform.up * upforce, ForceMode2D.Impulse);

        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            swordObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;


            transform.parent = other.transform;
            swordImpactSound.Play();
            grounded = true;

            swordObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;




            if (transform.position.x > 0)
            {
                transform.position = new Vector3(9.375f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 0);


            }
            else
            {
                transform.position = new Vector3(-9.375f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 180, 0);


            }

        }
        else if (other.CompareTag("Sky"))
        {
            SceneManager.LoadScene("MainScene");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);

            // gameController.GetComponent<GameController>().ResetGame();
        }
        else
        {
            return;
        }


    }


}
