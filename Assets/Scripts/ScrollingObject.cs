using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour {
    public float speed = 10f; // 초당 이동 속도

    private void Update() {
        // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
        transform.Translate(Vector3.left * speed * Time.deltaTime); // ( -1, 0, 0)으로 speed 만큼 이동, Time.deltaTIme은 컴퓨터의 성능차이를 해결하기 위한 역수 곱해주기
    }
}