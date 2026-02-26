using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    public float hitPoints = 100.0f;
    public float enemyHitPoints = 200.0f;
    public float dps = 12.0f;
    public TMP_Text playerHPText;
    public TMP_Text enemyHPText;
    public GameObject gameOver;
    public GameObject YouWin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver.SetActive(false);
        YouWin.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        //when spacebar is pressed, reduce enemy hitpoints by dps
        Keyboard k = Keyboard.current;
        if (k.spaceKey.wasPressedThisFrame) {
            enemyHitPoints -= dps;
            enemyHPText.SetText("HP: " + enemyHitPoints.ToString());
        }

        // automatically reduce player hitpoints by dps every second
        hitPoints -= dps * Time.deltaTime;
        playerHPText.SetText("HP: " + hitPoints.ToString("F2"));
        
        // check if player hitpoints are less than or equal to 0, if so, show "game over" panel
        if (hitPoints <= 0) {
            Debug.Log("Game Over");
            gameOver.SetActive(true);
            
        }
        if(enemyHitPoints <= 0) {
            Debug.Log("You Win!");
            YouWin.SetActive(true);
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
