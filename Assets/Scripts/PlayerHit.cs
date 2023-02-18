using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{
    public GameObject smoke;
    private int hp = 100;
    public Text hpText;
    private void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Instantiate(smoke, collision.transform.position, Quaternion.LookRotation(collision.impulse));
}           hp = hp - Random.Range(5, 30);
    }
    void Update()
    {
        
        hpText.text = hp.ToString();
        if (hp < 0) hp = 0;
        if (hp == 0)
        {
            SceneManager.LoadScene("Untitled");
        }
    }
}
