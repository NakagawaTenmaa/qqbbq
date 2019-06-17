var fs = require('fs');
var express = require('express');
var bodyParser = require('body-parser');
var db = require('./mysql/mysql');
let myutillty = require('./utillty/utillty');

var app = express();

app.use(bodyParser.urlencoded({ extended: true }));
app.set("view engine", "ejs");

// ユーザー作成
app.post('/api/create',(req,res)=>{
    console.log("sin_up");
    var _name = req.body["name"];
    var _pass = req.body["pass"];

        // DBで確認を行い返却
    var query = 'SELECT * FROM `users` WHERE `name` = "' + _name + '";';

    db.connection.query(query,function(err,rows,fields){
        console.log(rows);
        if(myutillty.isEmpty(rows) == true){                // ユーザーの登録
            query = 'INSERT INTO `users`(`name`, `password`) VALUES("'+ _name + '","' + _pass + '");';
            db.connection.query(query);
            query = 'SELECT * FROM `users` WHERE `name` = "' + _name + '";';
            db.connection.query(query,function(err,row,fields){
                res.send({
                    'id' : row[0].id
                });
            });
        } else {
        res.sendStatus(401);
        }
    });
});

// ユーザーログイン
app.post('/api/login',(req,res)=>{
    console.log("sin_in");
    var _name = req.body["name"];
    var _pass = req.body["pass"];
    // DBで確認を行い返却
    var query = 'SELECT * FROM `users` WHERE `name` = "' + _name + '";';
    
    db.connection.query(query,function(err,rows,fields){
        console.log(rows);
        if(myutillty.isEmpty(rows) == false){
            if(rows[0].password == _pass){
                // ログインを実行
                res.send({
                    'id': rows[0].id
                });
            }
            else {
                // パスワードが違う
                console.log("not password");
                res.sendStatus(401);
            }
        } else {
            // ユーザーの確認が取れない
            console.log("not user");
            res.sendStatus(401);
        }
    });
});

// 注文確定
app.post('/api/order',(req,res) =>{
    var data = JSON.parse(req.body["items"]);
    console.log(data);

    query = 'INSERT INTO `orders`(`user_id`, `item_id`,`num`) VALUES("'+ data["userid"] + '","' + data["id"] + '","'+ data["num"] +'");';
    db.connection.query(query);
    res.sendStatus(200);
});

app.get('/api/admin/order',(req,res) =>{
    const message = "Hello World!";
    res.render("index", {content: message});
});


// -------------------------------

// 共有
app.post('',(req,res)=>{
    res.render('index', { content: 'Hello' });
});


app.listen(10000);
console.log("server on");