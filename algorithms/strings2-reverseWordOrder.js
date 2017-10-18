/* 
CODING DOJO ALGORITHMS CHALLENGE: Reverse Word Order (pg. 107) 
Create a function that, given a string of words (with spaces), returns a new string with words in the reverse sequence. Given "This is a test", return "test a is This".

Bonus: Handle punctuation and capitalization. Given "Life is not a drill, go for it!", return "It for go, drill a not is life!"
*/

function reverseWordOrder(str) {
    var arr = [];
    var arr2 = [];
    var newWord = "";
    for (let i = 0; i < str.length; i++) {
        arr[i] = str[i];
    }
    for (let n = 0; n < arr.length; n++) {
        if (arr[n] != " ") {
            newWord += arr[n];
        }
        else if (arr[n] == " ") {
            arr2.push(newWord);
            newWord = "";
        }
    }
    newStr = arr2.reverse().join(" ");
    console.log(newStr);
}

reverseWordOrder("Hello dear how are you today?");