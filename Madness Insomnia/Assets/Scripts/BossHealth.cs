using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class BossHealth: MonoBehaviour 
{
    public int bosshealth;
    public int numofbosshearts;

    public Image[] hearts;
    public Sprite FullHeart;
    public Sprite emptyHeart;

    void Update(){

        if(bosshealth > numofbosshearts){
            bosshealth = numofbosshearts;
        }
         for (int i = 0; i < hearts.Length; i++) {

            if (i < bosshealth){
                hearts[i].sprite = FullHeart;
            }else{
                hearts[i].sprite = emptyHeart;
            }
            if(i < numofbosshearts) {
                hearts[i].enabled = true;
            } else {
                 hearts[i].enabled = false;
            }
            
        }
    }
    
}
