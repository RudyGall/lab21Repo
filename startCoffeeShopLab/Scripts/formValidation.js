﻿var namePattern = /^[a-zA-Z]{2,}$/
var ValidateFirstName = function () {
    if (namePattern.test(document.getElementById("FN").value)) {
        document.getElementById("message").style.color = "green"
        document.getElementById("message").innerHTML = "Valid"
    }
    else {
        document.getElementById("message").innerHTML = "Invalid"
        document.getElementById("message").style.color = "red"
    }
}
var namePattern = /^[a-zA-Z]{2,}$/
var ValidateLastName = function () {
    if (namePattern.test(document.getElementById("LN").value)) {
        document.getElementById("message2").style.color = "green"
        document.getElementById("message2").innerHTML = "Valid"
    }
    else {
        document.getElementById("message2").innerHTML = "Invalid"
        document.getElementById("message2").style.color = "red"
    }
}
var emailPattern = /^[A-z0-9]{5,30}(@)(.+){5,10}$/
var ValidateEmail = function () {
    if (emailPattern.test(document.getElementById("EM").value)) {
        document.getElementById("message3").style.color = "green"
        document.getElementById("message3").innerHTML = "Valid"
    }
    else {
        document.getElementById("message3").innerHTML = "Invalid"
        document.getElementById("message3").style.color = "red"
    }
}
var phonePattern = /^\d{10}$/
var ValidatePhoneNumber = function () {
    if (phonePattern.test(document.getElementById("PN").value)) {
        document.getElementById("message4").style.color = "green"
        document.getElementById("message4").innerHTML = "Valid"
    }
    else {
        document.getElementById("message4").innerHTML = "Invalid"
        document.getElementById("message4").style.color = "red"
    }
}
var passwordPattern = /^[a-zA-Z]\w{3,14}$/
var ValidatePassword = function () {
    if (passwordPattern.test(document.getElementById("PWD").value)) {
        document.getElementById("message5").style.color = "green"
        document.getElementById("message5").innerHTML = "Valid"
    }
    else {
        document.getElementById("message5").innerHTML = "Invalid"
        document.getElementById("message5").style.color = "red"
    }
}
var datePattern = /^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$/
var ValiDate = function () {
    if (datePattern.test(document.getElementById("DT").value)) {
        document.getElementById("message6").style.color = "green"
        document.getElementById("message6").innerHTML = "Valid"
    }
    else {
        document.getElementById("message6").innerHTML = "Invalid"
        document.getElementById("message6").style.color = "red"
    }
}
var agePattern = /^[1-9]$|^[1-9][0-9]$|^(100)$/
var ValidateAge = function () {
    if (agePattern.test(document.getElementById("AGE").value)) {
        document.getElementById("message7").style.color = "green"
        document.getElementById("message7").innerHTML = "Valid"
    }
    else {
        document.getElementById("message7").innerHTML = "Invalid"
        document.getElementById("message7").style.color = "red"
    }
}
var ssnPattern = /^\d{3}-?\d{2}-?\d{4}$/
var ValidateSSN = function () {
    if (ssnPattern.test(document.getElementById("SSN").value)) {
        document.getElementById("message8").style.color = "green"
        document.getElementById("message8").innerHTML = "Valid"
    }
    else {
        document.getElementById("message8").innerHTML = "Invalid"
        document.getElementById("message8").style.color = "red"
    }
}

