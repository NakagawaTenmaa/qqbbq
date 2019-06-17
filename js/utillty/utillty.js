function isEmpty(val){

    if ( !val ) {//null or undefined or ''(空文字) or 0 or false

        if ( val !== 0 && val !== false ) {
            console.log("空っぴ");
            return true;
        }
    }else if( typeof val == "object"){//array or object
        console.log("長さどんなもん?");
        if(Object.keys(val).length === 0){
            return true;
        } else {
            return false;
        }
    }
    console.log("はいってるぅぅぅぅ");
    return false;//値は空ではない
}

exports.isEmpty = isEmpty;