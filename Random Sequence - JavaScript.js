
// Any characters can be added here to include them in the generated sequence
const characters = '0123456789AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz';

// length: The length that you want the generated sequence to be
function generateSequence(length) {
    let seq = '';
    
    for(let i = 0; i < length; i++) {
        seq += characters[Math.floor(Math.random() * characters.length)];
    }
    
    return seq;
}

console.log(generateSequence(8));