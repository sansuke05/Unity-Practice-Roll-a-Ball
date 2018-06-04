using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;
	public GameObject player;
	
	void Update () {
		int count = GameObject.FindGameObjectsWithTag("Item").Length;
		scoreLabel.text = count.ToString();

		if(count == 0){
			// オブジェクトをアクティブにする
			winnerLabelObject.SetActive(true);
			// ボールの動きを止める
			player.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
	}
}
