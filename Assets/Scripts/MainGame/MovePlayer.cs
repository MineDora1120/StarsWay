using System.Collections;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    static public float moveSpeed = 5f;
    Animator playerAnimator;
    SpriteRenderer playerSprite;
    public RuntimeAnimatorController idle, run, jump;
    Rigidbody2D rb;
    bool isGround = true;
    public bool grass;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Move());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isGround = false;
            rb.AddForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -19.96f)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            playerSprite.flipX = true;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 19.96f)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            playerSprite.flipX = false;
        }
    }

    // Update is called once per frame
    IEnumerator Move()
    {
        while(true)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerAnimator.runtimeAnimatorController = jump;
                yield return new WaitForSeconds(0.7f);
                playerAnimator.runtimeAnimatorController = idle;
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) playerAnimator.runtimeAnimatorController = run;
            if ((Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)) || (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))) playerAnimator.runtimeAnimatorController = idle;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 땅에 닿았을 때 점프 상태를 초기화합니다.
        if (collision.gameObject.CompareTag("Ground")) isGround = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 땅에 닿았을 때 점프 상태를 초기화합니다.
        if (collision.gameObject.CompareTag("Grass")) grass = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // 땅에 닿았을 때 점프 상태를 초기화합니다.
        if (collision.gameObject.CompareTag("Grass")) grass = false;
    }
}
