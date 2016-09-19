using UnityEngine;

namespace RollingDice.UI {

	public class TabButton : UIButton {
		public  bool Window1;
		public  bool Window2;
		public MainMenuButton ButtonUI;

		public void TapButton1(){
			SaveTapPos (0);
		}

		public void TapButton2(){
			SaveTapPos (1);

		}

		public void TapButton3(){
			SaveTapPos (2);
		}

		void SaveTapPos(int i){

			if (Window1) {
				PlayerPrefs.SetInt ("Window1Tap", i);
				ButtonUI.TapWindow1 ();
			}

			if (Window2) {
				PlayerPrefs.SetInt ("Window2Tap", i);
				ButtonUI.TapWindow2 ();
			}

		
		}
	
	}
}
