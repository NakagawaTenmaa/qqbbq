//
// Index.js
// Author: Tamamura Shuuki
//

//var mysql = require('mysql');
/*
connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'tenko',
    database : 'qqbbq',
    password : 'tenko117'
 });
*/
// ユーザー名を設定する
var SetUserName = function(name){
    var user_name = document.getElementById('user_name');

    var newH1 = document.createElement("h1");
    newH1.className = 'user_name';
    newH1.textContent = name + 'さんの注文';
    user_name.appendChild(newH1);
}

// ユーザーIDを設定する
var SetUserID = function (id) {
    document.getElementById('user_id').innerHTML = 'ユーザーID: ' + id;
}

// 住所を設定する
var SetUserAddress = function (address) {
    document.getElementById('user_address').innerHTML = '住所: ' + address;
}

// 商品情報のデータ
var Product = {
    name: '' ,
    price: Int32Array,
}

// 金額カウント用
var count = 0;
// 商品の設定をする
var SetProduct = function(name, price){
    // リストの作成
    var list = document.getElementById('productList');

    // 合計金額
    var total = document.getElementById('total');

/*
    var query = 'SELECT * FROM `oeders` WHERE `user_id` = 99';
    db.connection.query(query,function(err,rows,fields){
        var length = Object.keys(rows).length;
        for(var i = 0; i < length ; i++ ){
            query = 'SELECT * FROM `item` WHERE `id` = ' + rows[i].item_id;
            db.connection.query(query,function(err,row,fields){

                var newLi = document.createElement("li");
                newLi.className = 'product';
                // 下DB連結
                newLi.textContent = row[0].name + ' ¥' + row[0].price;
                list.appendChild(newLi);
    
                count += row[0].price;
            });
        }
    });
   */  
    // リスト要素
    for(var i = 0; i < 10; i++)
    {
        var newLi = document.createElement("li");
        newLi.className = 'product';
        // 下DB連結
        
        newLi.textContent = name + ' ¥' + price;
        list.appendChild(newLi);

        count += price;
    }
}

// 合計を取得する
var GetTotal = function(){
    var total = document.getElementById('total');
    var newP = document.createElement("p");
    newP.className = 'total';
    newP.textContent = '合計: ¥' + count;
    total.appendChild(newP);
}