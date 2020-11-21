using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwordAttack : MonoBehaviour
{

    public GameObject swordObject, arrow, gameController, scoreController, swordEffects, actualSword;

    [HideInInspector] public GameObject theTriggered;

    [HideInInspector] public bool grounded, canCollide;

    public Animator swordAnimator;

    [HideInInspector] public bool gameIsOver, firstImpactSoundOccur;
    public float upforce;
    public AudioSource swordAttackSound, swordImpactSound;



    private void Start()
    {
        firstImpactSoundOccur = false;
        canCollide = true;
        grounded = false;
        gameIsOver = false;
    }
    public void Update()
    {
        //Debug.Log(arrow.transform.localEulerAngles.z);



        swordAnimator.SetBool("Grounded", grounded);


        //if ((transform.position.x < -5 || transform.position.x > 5) && grounded)
        //{
        //    gameObject.GetComponent<CircleCollider2D>().enabled = false;

        //}
        //else
        //{
        //    gameObject.GetComponent<CircleCollider2D>().enabled = true;

        //}


        if (grounded)
        {

            swordEffects.SetActive(false);
            /*  
            ////////////////////////////////////////////////////////////////////////////////
            ///////THE WALLS ARE TURNED, SO THE "X" POSITION LOOKS LIKE THE "Y" POSITION.///
            ////////////////////////////////////////////////////////////////////////////////
            if (transform.localPosition.x > 4.9f)
            {
                transform.localPosition = new Vector3(4.9f, transform.localPosition.y, transform.localPosition.z);
            }
            else if (transform.localPosition.x < -1.5f)
            {
                transform.localPosition = new Vector3(-1.5f, transform.localPosition.y, transform.localPosition.z);

            }*/

        }
        else
        {

            swordEffects.SetActive(true);

        }


        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Z))
        {

            if (Input.mousePosition.y < (Screen.height / 4) + (Screen.height / 2))

            {
                SwordAttackFunction();

            }
        }
        else if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.y < (Screen.height / 4) + (Screen.height / 2))
            {
                SwordAttackFunction();

            }


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



                //actualSword.transform.rotation = Quaternion.Euler(0, 180, 180);                
                //actualSword.transform.rotation = Quaternion.Euler(0, 180, 180);

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, -(arrow.transform.localEulerAngles.z - 360 + 90f));
                //actualSword.transform.rotation = Quaternion.Euler(0, 0, 0);

            }


            swordObject.GetComponent<Rigidbody2D>().AddForce(transform.up * upforce, ForceMode2D.Impulse);

        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall") && !grounded && canCollide)
        {
            //actualSword.transform.rotation = Quaternion.Euler(0, 0, 0);
            canCollide = false;
            swordObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;


            transform.parent = other.transform;
            if (firstImpactSoundOccur)
            {
                swordImpactSound.Play();

            }
            firstImpactSoundOccur = true;
            grounded = true;

            swordObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;




            if (transform.position.x > 0)
            {
                transform.position = new Vector3(9.61f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 0);


            }
            else
            {
                transform.position = new Vector3(-9.61f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 180, 0);



            }

        }
        else if (other.CompareTag("Sky"))
        {
            SceneManager.LoadScene("Game");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);

            // gameController.GetComponent<GameController>().ResetGame();
        }
        else if (other.CompareTag("ColliderEnabler"))
        {
            // ContactPoint contact = other.contacts[0];

            canCollide = true;
            // Vector3 position = contact.point;


        }
        else
        {
            return;
        }


    }


    public void TriggerSimulator(string theTriggerName)
    {
        if (theTriggerName == "Wall" && !grounded && canCollide)
        {

            Debug.Log("WORKS");

            //actualSword.transform.rotation = Quaternion.Euler(0, 0, 0);
            canCollide = false;
            swordObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;


            transform.parent = theTriggered.transform;
            swordImpactSound.Play();
            grounded = true;

            swordObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;




            if (transform.position.x > 0)
            {
                transform.position = new Vector3(9.61f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 0);


            }
            else
            {
                transform.position = new Vector3(-9.61f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 180, 0);



            }

        }
        else if (theTriggerName == "Sky")
        {
            SceneManager.LoadScene("Game");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);

            // gameController.GetComponent<GameController>().ResetGame();
        }
        else if (theTriggerName == "ColliderEnabler")
        {
            // ContactPoint contact = other.contacts[0];

            canCollide = true;
            // Vector3 position = contact.point;


        }
        else
        {
            return;
        }

    }

}
