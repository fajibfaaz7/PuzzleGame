using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButtons;
    public Sprite unSprite;


    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for(int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
            else
            {
                levelButtons[i].image.sprite = unSprite;
                //StartCoroutine(Unlock(i));
            }
        }
    }
    public void Select(string levelName)
    {
        fader.FadeTo(levelName);
    }

    //IEnumerator Unlock(int i)
    //{
    //    yield return new WaitForSeconds(.9f);
    //    levelButtons[i].image.sprite = unSprite;
    //}
}
