$("#OneNXForm").validate({
    onfocusout: function (element) { $(element).valid(); },
    errorPlacement: function (error, element) {
        error.appendTo(element.parent());
    },
    success: function (a, b) { 

    },
    errorElement: "span",
    container: '#errorMessage',
    rules: {
        Id: {
            required: true,
            digits: true,
            minlength: 3,
            maxlength: 6,
        },
        Name: {
            required: true,
        },
        TestX: {
            required: true,
        },
    },
    messages: {
        Id: {
            required: " (必需字段)",
            minlength: " (不能少于 3 个字母)"
        },
        Name: {
            required: " (必需字段)",
            minlength: " (字母不能少于 5 个且不能大于 12 个)",
            maxlength: " (字母不能少于 5 个且不能大于 12 个)"
        }
    }
});

$.validator.addMethod("isMobile", function (value, element) {
    var reg = /^((1[3-8][0-9])+\d{8})$/;
    return this.optional(element) || (reg.test(value));
}, "手机格式不正确");