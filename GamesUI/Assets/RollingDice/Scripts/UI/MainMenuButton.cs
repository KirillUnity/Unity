using UnityEngine;
using UnityEngine.UI;

namespace RollingDice.UI {
	
	public class MainMenuButton : UIButton {
		public GameObject Topbar;
		public TabButton tabButton;
		public GameObject WindowOne;
		public GameObject WindowTwo;
		public Animator Window1; 
		public Animator Window2; 
		public   Text[] TabWindow1;
		public   Text[] TabWindow2;
		public  GameObject[] HoverWindow1;
		public  GameObject[] HoverWindow2;

	
		void Start(){
			Topbar.SetActive (true);

		}


		public void TapWindow1(){
			Window1.SetBool ("On", true);
			Window2.SetBool ("On", false);

			WindowOne.SetActive (true);
			WindowTwo.SetActive (false);

			tabButton.Window1 = true;
			tabButton.Window2 = false;

			OffAllTab ();
			if (PlayerPrefs.HasKey ("Window1Tap")) {
				TabWindow1 [PlayerPrefs.GetInt ("Window1Tap") ].fontStyle = FontStyle.Bold;
				TabWindow1 [PlayerPrefs.GetInt ("Window1Tap") ].color = Color.black;
				HoverWindow1 [PlayerPrefs.GetInt ("Window1Tap") ].SetActive (true);

			} else {
				TabWindow1 [0].fontStyle = FontStyle.Bold;
				TabWindow1 [0].color = Color.black;
				HoverWindow1 [0].SetActive (true);

			}

		}
		public void TapWindow2(){
			Window1.SetBool ("On", false);
			Window2.SetBool ("On", true);
			WindowTwo.SetActive (true);
			WindowOne.SetActive (false);

			tabButton.Window2 = true;
			tabButton.Window1 = false;

			OffAllTab ();
			if (PlayerPrefs.HasKey ("Window2Tap")) {
				TabWindow2 [PlayerPrefs.GetInt ("Window2Tap") ].fontStyle = FontStyle.Bold;
				TabWindow2 [PlayerPrefs.GetInt ("Window2Tap") ].color = Color.black;
				HoverWindow2 [PlayerPrefs.GetInt ("Window2Tap")].SetActive (true);

			} else {
				TabWindow2 [0].fontStyle = FontStyle.Bold;
				TabWindow2 [0].color = Color.black;
				HoverWindow2 [0].SetActive (true);

			}
		}
		void OffAllTab(){

			for(int i=0; i<TabWindow1.Length;i++){
				TabWindow1 [i].fontStyle = FontStyle.Normal;
				TabWindow1 [i].color = Color.white;
				HoverWindow1 [i].SetActive (false);

			}
			for(int i=0; i<TabWindow2.Length;i++){
				TabWindow2 [i].fontStyle = FontStyle.Normal;
				TabWindow2 [i].color = Color.white;
				HoverWindow2 [i].SetActive (false);
			}
		}





	}

}

