﻿using System.Collections.Generic;
using System.Linq;

namespace ImitationLib.Utils
{
	public class Transact
	{
		private int _data;
		private List<string> _lifeTime;
		public string LifeTime
		{
			get { return this._lifeTime.Last(); }
			set
			{
				this._lifeTime.Add(value);
				Logger.Log.Debug(value);
			}
		}

		public Transact()
		{
			this._lifeTime = new List<string>();
			this._data = -1;
		}

		public Transact(System.Random random)
		{
			this._lifeTime = new List<string>();
			this._data = random.Next(1, 100);
		}

		public override string ToString()
		{
			return $"Transact {this._data}";
		}
	}
}