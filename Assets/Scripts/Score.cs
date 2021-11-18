using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    
    public Text scoreText;
    public Color scoreColor;

    public GameObject[] block;

    public int scoreVal = 0;

    private void Update()
    {
        block = GameObject.FindGameObjectsWithTag("Obstacle");
               
        foreach(GameObject b in block)
        {
            if (player.position.z > b.GetComponent<Transform>().position.z)
            {
                b.GetComponent<MeshRenderer>().material.color = scoreColor;
                b.tag = "Untagged";
                scoreVal++;
            }
        }                       
        scoreText.text = "Score " + scoreVal.ToString();
    }       
}

