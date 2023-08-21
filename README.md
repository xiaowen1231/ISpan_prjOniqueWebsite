# ISpan_prjOniqueWebsite

2023/8/25 資展國際 MSIT147期第三組 Onique 服飾網站

雲端資料庫下載
https://drive.google.com/file/d/1i5O5z7SRB6GU0ypWmD4RJtvdtcIpWIh1/view?usp=sharing

請於appsettings.json加入連線字串

在此專案負責開發的項目為:

會員登入授權:
使用技術:
使用CookieAuthenticationDefaults將會員登入資料儲存於cookie中，
並使用Claim類別判斷該登入帳號為資料庫中的員工帳號或會員帳號，
宣告使用者的ClaimTypes.Role儲存帳號的使用角色，
再使用[Authorize]針對不同的controller或action進行權限的管理
第三方登入:
呼叫Line Login 的API並指定Callback action可取得
token的line的使用者的姓名、照片、line每個帳號的唯一固定userId
將此轉為物件與資料庫資料比對，若無此userId則導向line綁定註冊頁，再填寫最基本的會員資料後綁定userId進lineUserId的欄位
有此userId則取回會員資料並幫會員完成登入導向網站首頁。


優惠功能:
前台:輪播廣告及優惠專區
輪播廣告讀取資料庫所有優惠活動並以圖片為資料進行輪播，
點擊輪播牆後可以此優惠的主索引鍵，
去搜尋資料庫中優惠ID有做關聯的商品資料，
並將資料組成DTO類別去判斷該商品有無優惠活動並在類別中進行計算返回優惠價格
商品的清單頁或首頁的所有商品卡片，
皆會呼叫AJAX後回傳資料先進行判斷有無優惠，
在動態生成不同樣式的優惠卡片，
並決定商品卡片的價格應顯示DTO中的原價或折扣價格。
並導向商品頁面顯示搜尋回來符合優惠活動的商品資料
優惠專區可顯示所有目前網站的商品優惠資訊。
後台:優惠管理
可新增優惠活動並設定活動的折扣方式，
並以bootstrap的modal以及，
以AJAX新增優惠內的商品並即時於載入或加入優惠當下做Callback更新頁面，
使得頁面可以不用重複return新的view便於連續加入商品，
並進行邏輯判斷預防重複加入商品導致優惠價格異常。


首頁推薦商品:
新商品推薦:
依照商品資料表的上架時間去做排序回傳商品上架時間最新的前四筆資料，
熱銷商品:
以left join與 sum函式去計算商品於訂單明細中出現的總計次數，
使得資料不管是否為null皆會回傳合計的下訂總數，
再以此為排序並取得前四筆熱銷商品推薦給使用者



