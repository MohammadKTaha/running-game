using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Obisticale
	{
		private GameObject obisticale;
		private string name;
		private float xLocation;
		private float yLocation;
		private float zLocation;
		private float zDimintion;
		public Obisticale (GameObject obisticale)
		{
			this.obisticale = obisticale;
		}

		public Obisticale (GameObject obisticale,string name)
		{
			this.obisticale = obisticale;
			setName(name);
		}

		public Obisticale ()
		{

		}

		public GameObject getObistical(){
			return this.obisticale;
		}

		public void setObisticale(GameObject obisticale){
			this.obisticale = obisticale;
			calculateObisticaleZDimintion();
		}


		public string getName(){
			return this.name;
		}

		public void setName(string name){
			this.name = name;
		}

		public float getXLocation(){
			return this.xLocation;
		}

		public void setXlocation(float xLocation){
			this.xLocation = xLocation;
		}

			public float getYLocation(){
			return this.yLocation;
		}

		public void setYlocation(float yLocation){
			this.yLocation = yLocation;
		}


		public float getZLocation(){
			return this.zLocation;
		}

		public void setZlocation(float zLocation){
			this.zLocation = zLocation;
		}


		public float getZDimintion(){
			return this.zDimintion;
		}

		public void setZDimintion(float zDimintion){
			this.zDimintion = zDimintion;
		}

		void calculateObisticaleZDimintion(){
			zDimintion = this.obisticale.transform.localScale.z;
		}

	}
}

