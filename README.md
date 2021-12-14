# Uni_run

## 오류

### 21.12.02 
1. ~~캐릭터 애니메이션 작동 X~~ 21.12.02
2. ~~Deadzone 트리거 작동 X~~ 21.12.02
3. ~~발판이 이상한 곳에 생기고, 화면에 넘어가기 전에 사라짐~~ 21.12.06  
    PlatformSpawner.cs 에서 
    ```C#
        // count = 발판의 개수
        // 마지막 배치 시점(lastSpawnTime)에서 timeBetSpawn 이상 시간이 흘렀다면 인덱스를 증가시켜, 다음 인덱스의 발판을 지정 위치로 이동시키는 코드
        // 아래 코드에서 발판의 개수를 1개로 해두고 테스트를 했기에, 발판이 카메라를 다 지나가기도 전에 지정된 위치로 이동하게 된것
         if (Time.time >= lastSpawnTime + timeBetSpawn)
        {
            // 기록된 마지막 배치 시점을 현재 시점으로 갱신
            lastSpawnTime = Time.time;

            // 다음 배치까지의 시간 간격을 timeBetSpawnMin, timeBetSpawnMax 사이에서 랜덤 설정
            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);

            // 배치할 위치의 높이를 yMin과 yMax 사이에서 랜덤 설정
            float yPos = Random.Range(yMin, yMax);

            // 사용할 현재 순번의 발판 게임 오브젝트를 비활성화하고 즉시 다시 활성화
            // 이때 발판의 Platform 컴포넌트의 OnEnable 메서드가 실행됨
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);

            // 현재 순번의 발판을 화면 오른쪽으로 재배치
            platforms[currentIndex].transform.position = new Vector2(xPos, yPos);
            // 순번 넘기기
            currentIndex++;

            // 마지막 순번에 도달했다면 순번을 리셋
            if (currentIndex >= count)
            {
                currentIndex = 0;
            }
    ```
4. ~~발판이 생기지 않음~~ 21.12.06  
    Platform 프리펩에 잘못된 스크립트가 들어가 있었음 (BackgroundLoop) // 3번 오류에도 영향을 끼치고 있었음
5. ~~깃허브 데스크탑에 유니티 프로젝트를 export한 unitypackage 파일이 잡히지 않음~~  
확인해보니 .gitignore에 unitypackage 파일이 리스트에 있어서 안 잡힌 것  
*.unitypackage => #*.unitypackage
주석처리를 해주니 다시 잡힘

## 참고한 책
레트로의 유니티 게임 프로그래밍 에센스 - 이제민 - 

## 유니티 버전
2020.3.23fl
