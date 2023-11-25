using UnityEngine;
using static UnityEngine.ParticleSystem;

public class item_11 : MonoBehaviour
{
    private ParticleSystem mushParticle;
    // Start is called before the first frame update
    void Start()
    {
        mushParticle = GetComponent<ParticleSystem>();
    }
    private void FixedUpdate()
    {
        if (ClickInGameButton.isStop && mushParticle.isPlaying)
        {
            mushParticle.Clear();
            mushParticle.Stop();
        }
        else if(!ClickInGameButton.isStop && !mushParticle.isPlaying) mushParticle.Play();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) MainGameManager.HP--;
    }
}
