$(function() {   
    $("#RegisterForm").validate({
        debug:true,  
        rules: {  
            username: "required",  
            studentID: {
                digits:true
            },
            email: {  
                required: true,  
                email: true  
            },
            password: {  
                required: true,  
                minlength: 8,
                maxlength: 16  
            },  
            password_confirm: {  
                equalTo: "#password"  
            }
      
        },  
        messages: {  
            username: "請輸入姓名",  
            password: {  
                required: "請輸入密碼",  
                minlength: jQuery.format("密碼不能小於{0}個字 符")  
            },  
            password_confirm: {  
                equalTo: "兩次密碼不一樣"  
            },  
            email: {  
                required: "請輸入郵箱",  
                email: "請輸入有效郵箱"  
            }  
        }  
    });  
});