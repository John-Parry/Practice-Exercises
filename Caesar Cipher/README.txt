// NOTES:
//
// The formula to get an ASCII decimal value shifted by any number whilst looping every time it goes out of bounds both ways is as follows:
// 
// ((original_character_decimal + shift - MINIMUM_ASCII_LETTER_DECIMAL) % ALPHABET_LENGTH) + MINIMUM_ASCII_LETTER_DECIMAL
//
// Where:
// - 'original_character_decimal' is the ASCII decimal representation of the alphabetical character you wish to shift
// - 'shift' is the value by which you wish to shift the character
// - 'MINIMUM_ASCII_LETTER_DECIMAL' is the ASCII decimal reprisentation of the letter 'a' (97) or 'A' (65), depending on if you're working with the uppercase or lowercase range of characters
// - 'ALPHABET_LENGTH' is the length of the alphabet, 26
//
// The methodology is that we're first adding / subtracting the shift number to the ASCII character decimal to create a shifted ASCII decimal
// After that, we turn the shifted ASCII decimal into a shifted primative decimal by subtracting 97 ('a') if the letter was lowercase or 65 ('A') if it was uppercase
// The primative encoding is one where a/A = 0 and z/Z = 25, all the letters are either all lowercase or uppercase
// This is due to the fact the % opperator is able to loop sequences propperly when they start from 0, in this case, a/A
// Next, we use the % opperator to give us the remainder of the shifted primative decimal, and we add back the number we originally subtracted so it is ASCII compatible
// In the end, this has always given me good, 100% accurate results, so despite my lack of understanding, i follow the words of Todd H: "It just works"
//
// Sorry, i am REALLY bad at giving explanations of how mathmatical algorithms work