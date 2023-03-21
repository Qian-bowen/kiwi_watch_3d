using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {
	[Range(0.0f, 10.0f)]
	public float moveSpeed = 3.0f;
	private Vector2 _hidePos;
	private Vector2 _showPos;
	private RectTransform _rectTransfrom;
	private bool _isShow;
	// Use this for initialization
	void Start () {
		_rectTransfrom = this.gameObject.GetComponent<RectTransform>();
		_hidePos = _rectTransfrom.anchoredPosition;
		_showPos = new Vector2(_hidePos.x + _rectTransfrom.rect.width, _hidePos.y);
		_isShow = false;
    }
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.Tab)){
				if(_isShow){
					HideMenu();
                }
				else{
					ShowMenu();
                }
            }
    }
	public void showUI(){

		if(_isShow){
			HideMenu();
        }
		else{
			ShowMenu();
        }
    }
	public void ShowMenu(){
		StartCoroutine(Appear());
    }
	public void HideMenu(){
		StartCoroutine(Disappear());
    }
	IEnumerator Disappear(){
		_isShow = false;
		float time = Time.time;
		float timeDiff = 0;
		while(timeDiff < 1){
			timeDiff = (Time.time - time) * moveSpeed;
			Vector2 currentPos = Vector2.Lerp(_showPos, _hidePos, timeDiff);
			_rectTransfrom.anchoredPosition = currentPos;
			yield return new WaitForEndOfFrame();
		}
	}
	IEnumerator Appear(){
		float time = Time.time;
		float timeDiff = 0;
		while(timeDiff < 1){
			timeDiff = (Time.time - time) * moveSpeed;
			Vector2 currentPos = Vector2.Lerp(_hidePos, _showPos, timeDiff);
			_rectTransfrom.anchoredPosition = currentPos;
			yield return new WaitForEndOfFrame();
		}
		_isShow = true;
	}
}