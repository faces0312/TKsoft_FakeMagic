using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MonoBehaviour
{
    public Animator die;
    public Mob1_Body mob1_Body;

    public SpriteRenderer rend;
    Vector3 start;
    Vector3 fin;

    public Rigidbody2D target;

    public float hp;
    public float speed;
    // Update is called once per frame

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        target = Manager.manager.player.GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        hp = Data.Instance.gameData.mob1_hp;
        speed = 1.1f;
        //target_on = false;
        mob1_Body.gameObject.SetActive(true);
        //StartCoroutine(FindPlayer());
    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && hp > 0)
        {
            target_on = true;
            end = collision.transform.position;

            fin = end - start;
            if (fin.x > 0)
                rend.flipX = true;
            else
                rend.flipX = false;
        }
    }*/

    /*public IEnumerator FindPlayer()
    {
        end = GameObject.FindObjectOfType<Player>().transform;
        yield return new WaitForSeconds(find_num);
        StartCoroutine(FindPlayer());
    }*/

    private void FixedUpdate()
    {
        fin = target.transform.position - start;
        if (fin.x > 0)
            rend.flipX = true;
        else
            rend.flipX = false;
        start = this.transform.position;
        transform.position = Vector3.MoveTowards(start, target.transform.position, speed * Time.deltaTime);

        //transform.position = Vector3.MoveTowards(start, Camera.main.transform.position, speed * Time.deltaTime);
    }

    public void Die()
    {
        //StopCoroutine(nameof(FindPlayer));
        mob1_Body.StopAllCoroutines();
        gameObject.SetActive(false);
    }
}