/* 
RECURSION: Telephone Words (pg. 102)
Given a 7-digit telephone number, return an array of all possible strings that equate
to the phone number. Mapping:

0: O;
1: I;
2: ABC;
3: DEF;
4: GHI;
5: JKL;
6: MNO;
7: PQRS;
8: TUV;
9: WXYZ;

INPUT (str) => "818-2612"
OUTPUT (arr of str) => 243 total combos including ["vitamic", "titania", ...]
*/

var keyMappingObject = {
  "0": ["O"],
  "1": ["I"],
  "2": ["A", "B", "C"],
  "3": ["D", "E", "F"],
  "4": ["G", "H", "I"],
  "5": ["J", "K", "L"],
  "6": ["M", "N", "O"],
  "7": ["P", "Q", "R", "S"],
  "8": ["T", "U", "V"],
  "9": ["W", "X", "Y", "Z"]
};

var keyMappingArray = [
  ["O"],
  ["I"],
  ["A", "B", "C"],
  ["D", "E", "F"],
  ["G", "H", "I"],
  ["J", "K", "L"],
  ["M", "N", "O"],
  ["P", "Q", "R", "S"],
  ["T", "U", "V"],
  ["W", "X", "Y", "Z"]
];

// Provided test case
var testPhoneNum = "818-2612";
// Format phone number as array of numbers
testPhoneNum = testPhoneNum.slice(0, 3) + testPhoneNum.slice(3 - 7);
testPhoneNum = testPhoneNum.split("");

console.log(testPhoneNum);

// Declare variables for pointer and empty solution array
var pointer = 0;
var solution = [""];

function telephoneWords(testPhoneNum, solution, pointer) {
  while (pointer < testPhoneNum.length) {
    // Find all possible values at pointer in the keymap
    result = keyMappingArray[testPhoneNum[pointer]];
    if (result.length == 1) {
      for (let n = 0; n < solution.length; n++) {
        solution[n].concat(result[0]);
      }
      // console.log(solution);
    } else {
      // Loop through possible values
      for (let i = 0; i < result.length; i++) {
        for (let n = 0; n < solution.length; n++) {
          solution[n].concat(result[i]);
        }
        // solution.push(result[i]);
        console.log(solution);
      }
    }
    pointer++;
  }
}

telephoneWords(testPhoneNum, solution, pointer);

// console.log(testPhoneNum);
// console.log(keyMappingArray);
// console.log(keyMappingObject);

// function telephoneWords(phoneNum, results, currPointer) {
//     while (currPointer < phoneNum.length) {
//         // console.log(currPointer);
//         let currentNum = phoneNum[currPointer];
//         let currentLetter = keyMappingArray[currentNum];

//         if (currentNum == 0 || currentNum == 1) {
//             results.push(keyMappingArray[currentNum]);
//             console.log(results);
//         }

//         else {

//         }

//         console.log(currentNum);
//         console.log(currentLetter);
//         currPointer += 1;
//     }
//     // console.log(solution);
// }

// telephoneWords(testPhoneNum, results=[], currPointer=0);
