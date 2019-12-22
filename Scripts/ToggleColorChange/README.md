# Toggleスイッチの中身の色変えるやつ

## 使い方
1. このスクリプトを適当なゲームオブジェクトにアタッチ（トグル本体につけるのが吉）
2. State Sourceに対象となるToggleをセット
3. State SourceにセットしたToggleの「Graphic」欄をNoneにする
4. Target graphicにToggleの状態によって色を変えたいImageをセット
5. Active Color, Deactive Colorにそれぞれ色をセット
6. 使う

## 何ができるか
Toggleの状態に合わせて特定Imageの色を変えられる。
通常ToggleはToggleの状態に合わせてCheckmarkを「表示する」か「表示しない」の二択しか取れないようなので作った。
