using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory {

	[SerializeField] private GameObject[] enemyPrefab;

	public GameObject FactoryMethod (int tag)
	{
		GameObject enemy = Instantiate (enemyPrefab[tag]);
		return enemy;
	}
}
