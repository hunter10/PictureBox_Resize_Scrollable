# PictureBox_Resize_Scrollable

1. 디폴트 윈도우 생성(300, 300)
2. 버튼 배치 - 좌상단에 맞게
3. 판넬 배치 - 디폴트크기로 윈도우 크기에 맞게 (284, 219)
4. 판넬 속성변경 - AutoScroll - True, Anchor - 4방향 다 켜고, BackColor - 아무색이나 변경
5. PictureBox 배치 - 디폴트 크기로 판넬크기에 맞게 (284, 219, 마진 다 0)
6. PictureBox 속성변경 - BackColor - 판넬하고 다르게, 이때 Dock 옵션을 fill로 주면 스크롤안됨
7. 버튼에서 이미지 로드 루틴 추가하고
8. PictureBox 사이즈에 로드한 이미지 사이즈 세팅하고
9. 윈도우 닫을때 PictureBox 정리
