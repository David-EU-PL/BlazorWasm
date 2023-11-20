function addNumberJS(number1, number2) {
    var sum = number1 + number2;
    alert(sum);
}

function addNumberCSharp(number1, number2) {
    DotNet.invokeMethodAsync("BlazorWasm", "Add", parseInt(number1), parseInt(number2))
        .then(result => {
            alert(result);
        })
}

function GetCurrentDateCSharp() {
    return DotNet.invokeMethodAsync("BlazorWasm", "GetCurrentDate")
}