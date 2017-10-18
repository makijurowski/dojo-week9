/* Coding Dojo Algorithms Challenge: String Anagrams
Given a string, return an array where each element is a string representing 
a different anagram (a different sequence of letters in that string). 
For example, if given "lim", return ["ilm", "iml", "lim", "lmi", "mil", "mli"].
*/

var randIdx = 0, idx = 0, temp = "", anagramCount = 1, resultsObj = {}, resultsArr;

// Main function to use recursively to find anagram combinations
function stringAnagrams(str, resultsArr=[], numPossible=stringNumOfAnagrams(str)) {
    // Base case
    if (resultsArr.length === numPossible) {
        return resultsArr;
    }
    else {
        // Split string into an array
        str = str.split("");
        // Shuffle the letters
        for (idx = str.length - 1; idx > 0; idx--) {
            randIdx = Math.floor(Math.random() * (idx + 1));
            temp = str[idx];
            str[idx] = str[randIdx];
            str[randIdx] = temp;
        }
        // Create a new string by joining the letters in the array
        str = str.join(""); 
        // Try adding to resultsObj object
        resultsObj[str] = "";
        resultsArr = Object.keys(resultsObj);
    }
    // Recursive call
    return stringAnagrams(str, resultsArr, numPossible);
}

// Function to calculate total number of possible anagrams
function stringNumOfAnagrams(str) {
    for (idx = 0; idx < str.length; idx++) {
        anagramCount = (anagramCount * (idx + 1));
    }
    return anagramCount;
}

console.log("Test Case: " + stringAnagrams("maki"));