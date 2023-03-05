using UnityEngine;
using UnityEngine.InputSystem;

namespace _project.Scripts.Input {
	[CreateAssetMenu(fileName = "InputReader", menuName = "Input/Input Reader", order = 0)]
	public class InputReader : ScriptableObject, GameInput.IMainActions {
		
		private GameInput gameInput;
		
		private void OnEnable() {
			if ( gameInput == null ) {
				gameInput = new GameInput();
				gameInput.Main.SetCallbacks(this);
			}

			EnableMainInput();
		}
		
		private void EnableMainInput() {
			gameInput.Main.Enable();
		}
		
		private void DisableMainInput() {
			gameInput.Main.Disable();
		}
		
		// Input Events
		
		public void OnQuit(InputAction.CallbackContext context) {
			Debug.Log("Quit!");
			Application.Quit();
		}
	}
}