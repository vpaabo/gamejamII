using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnvironmentSpawner : MonoBehaviour
{
    public int TreeAmount;
    public int EnemyAmount;
    public int StoneAmount;


    public GameObject Memm;
    public GameObject Tree;
    public GameObject Stone;

    public PlayerAttack player;

    [Space]
    private int sizeX;
    private int sizeZ;


    public PlayerAttack aInstance;
    public TextMeshProUGUI score;

    IEnumerator Start()
    {
        yield return new WaitUntil(() => aInstance.IsInitialized);

        player = GameObject.Find("Player").GetComponent<PlayerAttack>();
        sizeX = (int)transform.localScale.x * 10;
        sizeZ = (int)transform.localScale.z * 10;

        for (int k = 0; k < StoneAmount; k++)
        {
            GameObject.Instantiate(Stone, new Vector3((Random.value - .5f) * sizeX, 0, (Random.value - .5f) * sizeZ), Quaternion.identity);

        }
        for (int k = 0; k < EnemyAmount; k++)
        {
            GameObject m =  GameObject.Instantiate(Memm, new Vector3((Random.value - .5f) * sizeX, 0, (Random.value - .5f) * sizeZ), Quaternion.identity);
            player.AddEnemyToList(m);
        }
        for (int i = 0; i < TreeAmount; i++)
        {
            GameObject.Instantiate(Tree, new Vector3((Random.value - .5f)*sizeX, 0, (Random.value - .5f) * sizeZ), Quaternion.identity);
        }
        //print(player.enemies.Count);    
    }

    private void Update()
    {
        score.text = "Score: " + player.Score;
    }

}
