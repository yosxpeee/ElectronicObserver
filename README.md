
# 七四式電子観測儀

現在鋭意開発中の艦これ補助ブラウザです。  

**本リポジトリ(https://github.com/yosxpeee/ElectronicObserver)**  
**は管理者の艦これ引退に伴い更新停止となります。**

## 実装されている機能

![](https://user-images.githubusercontent.com/29325179/179132233-a94d0b42-06e6-48ed-b23f-fb544dec1a31.png)

各機能はそれぞれウィンドウとして独立しており、自由にドッキング・タブ化するなどしてレイアウト可能です。  
以下では概略を紹介します。**詳しくは[Wikiを参照](https://github.com/yosxpeee/ElectronicObserver/wiki)してください。**  

* 内蔵ブラウザ(スクリーンショット, ズーム, ミュートなど)
* 艦隊(状態(遠征中, 未補給など), 制空戦力, 索敵能力)
    * 個艦(Lv, HP, コンディション, 補給, 装備スロット)
    * 艦隊一覧(全艦隊の状態を一目で確認できます)
    * グループ(フィルタリングで艦娘情報を表示)
* 入渠(入渠艦, 残り時間)
* 工廠(建造中の艦名, 残り時間)
* 司令部(提督情報, 資源情報)
* 羅針盤(次の進路, 敵編成・獲得資源等のイベント予測)
* 戦闘(戦闘予測・結果表示)
* 情報(中破絵未回収艦一覧, 海域ゲージ残量など)
* 任務(達成回数/最大値表示)
* 図鑑(艦船/装備図鑑)
* 装備一覧
* 通知(遠征・入渠完了, 大破進撃警告など)
* レコード(開発・建造・ドロップ艦の記録など)
* ウィンドウキャプチャ(他プログラムのウィンドウを取り込む)

なお、全ての機能において艦これ本体の送受信する情報に干渉する操作は行っていません。


## ダウンロード

[リリースページ](https://github.com/yosxpeee/ElectronicObserver/releases) を参照してください。

[更新内容・履歴はこちらで確認できます。](https://github.com/yosxpeee/ElectronicObserver/wiki/ChangeLog)  


## 開発者の皆様へ

ライセンスは [MIT License](https://github.com/yosxpeee/ElectronicObserver/blob/master/LICENSE) です。


## 使用しているライブラリ

* [DynaJson](https://github.com/fujieda/DynaJson) (JSON データの読み書き) - [MIT License](https://github.com/yosxpeee/ElectronicObserver/blob/master/Licenses/DynaJson.txt)
* [DockPanel Suite](http://dockpanelsuite.com/) (ウィンドウレイアウト) - [MIT License](https://github.com/yosxpeee/ElectronicObserver/blob/master/Licenses/DockPanelSuite.txt)
* [Nekoxy](https://github.com/veigr/Nekoxy) (通信キャプチャ) - [MIT License](https://github.com/yosxpeee/ElectronicObserver/blob/master/Licenses/Nekoxy.txt)
    * [TrotiNet](http://trotinet.sourceforge.net/) - [GNU Lesser General Public License v3.0](https://github.com/yosxpeee/ElectronicObserver/blob/master/Licenses/LGPL.txt)
        * [log4net](https://logging.apache.org/log4net/) - [Apache License version 2.0](https://github.com/yosxpeee/ElectronicObserver/blob/master/Licenses/Apache.txt)


## Fork元について

* 下記Fork元の方は開発対応の終了を正式に宣言されておりますので、直接の連絡はお控えください
	* 配布サイト:[ブルネイ工廠電気実験部](http://electronicobserver.blog.fc2.com/)
	* 開発:[Andante](https://twitter.com/andanteyk)

## このリポジトリでの更新履歴

[更新履歴](https://github.com/yosxpeee/ElectronicObserver/wiki/ChangeLog) を参照ください。

