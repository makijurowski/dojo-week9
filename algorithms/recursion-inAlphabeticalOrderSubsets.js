/* 
RECURSION: In-Order Subsets (pg. 101)
Create a strSubsets(str), return an array with every possible
in-order character subset of str. The results array itself does not 
need to be in any specific order--it is the subset of letters in each 
string that must be in the same order as they were in the original.

INPUT (str) => "abc"
OUTPUT (arr) => ["", "a", "b", "c", "ab", "ac", "bc", "abc"]
*/


function strSubsets(str, results=[], strArray=[]) {
    if (results.length == 0) {
        results.push("");
        strArray = str.split("");
        strSubsets(str, results, strArray);
    }
    else if (strArray.length == 0) {
        return results;
    }
    else {
        for (var n = 0; n < strArray.length; n++) {
            for (var i = 0; i < results.length; i++) {
                console.log("strArray: " + strArray + " and results: " + results);
                stringLetter = strArray[n];
                console.log("stringLetter: " + stringLetter);
                resultsLetter = results[i];
                console.log("resultsLetter: " + resultsLetter);
                console.log("indexOf: " + results.indexOf(stringLetter));
                if (!stringLetter) {
                    return results;
                }
                else if (stringLetter.toLowerCase() != stringLetter) {
                    strArray = strArray.slice(n + 1);
                    console.log("stringLetter: " + stringLetter);
                    console.log("first nested if of results: " + results);
                    strSubsets(str, results, strArray);
                }
                else if (stringLetter.localeCompare.resultsLetter > 0) {
                    results[i] = resultsLetter + stringLetter;
                    console.log("second nested if of results: " + results);
                }
                else if (results.indexOf(stringLetter) === -1) {
                    results.push(stringLetter);
                    console.log("third nested if of results: " + results);
                }
                else {
                    strArray = strArray.slice(n + 1);
                    console.log("forth nested if of results: " + results);
                    strSubsets(str, results, strArray);
                }
            }
        }
    }
    console.log(results);
    return results;
}

console.log(strSubsets("hello"));