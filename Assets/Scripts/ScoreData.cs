﻿using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu]
public class ScoreData : ScriptableObject
{
	public int Amount => m_score;
	[SerializeField,ReadOnly]private int m_score;

	public void AddScore(int amount)
	{
		m_score += amount;
	}

	public void RemoveScore(int amount)
	{
		m_score -= amount;
	}

	private void OnEnable()
	{
		m_score = 0;
	}

	private void OnDisable()
	{
		m_score = 0;
	}
}