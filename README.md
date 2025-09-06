# 2D Turn-Based Battle Game

Unity로 개발된 2D 턴제 배틀 게임 프로젝트입니다. 메이플스토리와 같은 사이드 뷰 탐험과 포켓몬스터 시리즈와 유사한 턴제 전투 시스템을 구현합니다.

## 프로젝트 개요

- **장르**: 2D 턴제 RPG (사이드 뷰)
- **엔진**: Unity 2022 LTS
- **언어**: C#
- **플랫폼**: PC (Unity Editor)
- **개발 단계**: MVP (Minimum Viable Product)

## 주요 기능

### 현재 구현된 기능

#### 플레이어 이동 시스템
- **상태 기반 이동**: Idle, Move, Jump, Fall 상태 관리
- **커맨드 패턴**: 이동 명령을 캡슐화하여 실행
- **물리 기반 이동**: Rigidbody2D를 활용한 2D 물리 시스템
- **입력 처리**: Unity Input System을 통한 키보드/게임패드 지원

#### 입력 시스템
- **다중 입력 지원**: 키보드, 마우스, 게임패드, 터치스크린
- **입력 액션**: Move, Jump, Fire, UI 네비게이션
- **입력 매핑**: WASD, 화살표 키, 스페이스바 지원

#### 아키텍처 패턴
- **상태 패턴**: 플레이어 상태 관리 (State Machine)
- **커맨드 패턴**: 플레이어 액션 캡슐화
- **싱글톤 패턴**: 매니저 클래스 관리
- **컴포넌트 기반**: 모듈화된 시스템 설계

### 개발 예정 기능

#### 전투 시스템
- **턴제 전투**: 플레이어 vs 몬스터 1:1 전투
- **랜덤 인카운터**: 풀숲에서 몬스터와의 랜덤 배틀
- **스킬 시스템**: 다양한 공격 기술과 효과
- **데미지 계산**: 공격력, 방어력을 고려한 데미지 공식

#### 맵 시스템
- **사이드 뷰 맵**: 평지와 풀숲 지역
- **인카운터 트리거**: 특정 지역에서 몬스터 출현
- **씬 전환**: 탐험 → 전투 → 탐험 순환

#### 데이터 관리
- **ScriptableObject**: 캐릭터, 몬스터, 스킬 데이터 관리
- **확장성**: 향후 Google Sheets API 연동 준비

## 프로젝트 구조

```
Assets/03_Scripts/
├── Player/                    # 플레이어 관련 스크립트
│   ├── Command/              # 커맨드 패턴 구현
│   │   ├── PlayerCommandInvoker.cs
│   │   ├── PlayerMovementBaseCommand.cs
│   │   ├── PlayerMoveLeftCommand.cs
│   │   ├── PlayerMoveRightCommand.cs
│   │   ├── PlayerMoveStopCommand.cs
│   │   └── PlayerJumpCommand.cs
│   ├── State/                # 상태 패턴 구현
│   │   ├── PlayerStateMachine.cs
│   │   ├── PlayerIdleState.cs
│   │   ├── PlayerMoveState.cs
│   │   ├── PlayerJumpState.cs
│   │   └── PlayerFallState.cs
│   ├── PlayerController.cs   # 플레이어 메인 컨트롤러
│   ├── PlayerMovement.cs     # 이동 로직
│   ├── PlayerInputGetter.cs  # 입력 처리
│   └── PlayerSpriteManager.cs # 스프라이트 관리
├── Battle System/            # 전투 시스템 (개발 예정)
│   └── BattleSystem.cs
├── Command/                  # 커맨드 패턴 베이스
│   └── CommandBase.cs
├── State/                    # 상태 패턴 베이스
│   └── StateBase.cs
├── Singleton/                # 싱글톤 패턴
│   └── Singleton.cs
├── Manager/                  # 매니저 클래스들
│   └── CameraManager.cs
└── Input Actions/            # Unity Input System
    ├── 2DTurnGame.cs
    └── 2DTurnGame.inputactions
```

## 조작법

### 키보드
- **이동**: A/D 키 또는 ←/→ 화살표 키
- **점프**: 스페이스바
- **공격**: 마우스 왼쪽 클릭 (개발 예정)

### 게임패드
- **이동**: 왼쪽 스틱 또는 D-Pad
- **점프**: A 버튼
- **공격**: RT 버튼 (개발 예정)

## 시작하기

### 요구사항
- Unity 2022.3 LTS 이상
- Visual Studio 또는 유사한 C# IDE

### 설치 및 실행
1. 프로젝트를 클론합니다
2. Unity Hub에서 프로젝트를 엽니다
3. `Assets/Scenes/SampleScene.unity` 씬을 열어 실행합니다

## 기술 스택

- **Unity 2022 LTS**: 게임 엔진
- **C#**: 스크립팅 언어
- **Unity Input System**: 입력 처리
- **Unity Physics 2D**: 2D 물리 시스템
- **Unity Animator**: 애니메이션 시스템

## 개발 로드맵

### Phase 1: 기본 시스템 (완료)
- [x] 플레이어 이동 시스템
- [x] 상태 머신 구현
- [x] 입력 시스템 구축
- [x] 기본 아키텍처 설계

### Phase 2: 전투 시스템 (개발 중)
- [ ] 전투 씬 구현
- [ ] 턴제 전투 로직
- [ ] 몬스터 AI 시스템
- [ ] 스킬 시스템

### Phase 3: 맵 및 인카운터 (계획)
- [ ] 사이드 뷰 맵 제작
- [ ] 랜덤 인카운터 시스템
- [ ] 씬 전환 로직

### Phase 4: 데이터 관리 (계획)
- [ ] ScriptableObject 데이터 구조
- [ ] 캐릭터/몬스터/스킬 데이터
- [ ] 밸런싱 시스템