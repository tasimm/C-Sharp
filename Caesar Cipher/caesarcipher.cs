// Program that can encrypt or decrypt messages using a Caesar Cipher

using System;

namespace CaesarCipher
{
  class Program
  {
    public static class Globals {
      //This makes it so the alphabet array can be accessed in multiple methods so it doesn't need to be defined each time.
      public static char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    }

    // Our method for encrypting messages
    static void Encrypt() {
      Console.Write("Enter a message to encrypt: ");
      string input = Console.ReadLine().ToLower(); // ensure message is lowercase
      char[] secretMessage = input.ToCharArray();  // turn message into an array
      // Array that will hold the encrypted message
      char[] encryptedMessage = new char[secretMessage.Length];
      // Loop through the message
      for (int i = 0; i < secretMessage.Length; i++) {
          // Checks for special characters like ! or ? and skips them
          char ch = secretMessage[i];
          bool alpha = Char.IsLetter(ch);
          if (alpha == false) {
            continue;
          }
          else {
              // Takes each character from the original message and moves them three places to the right in the alphabet to encrypt it
              char letter = secretMessage[i];
              int letterPosition = Array.IndexOf(Globals.alphabet, letter);
              int newLetterPosition = (letterPosition + 3) % Globals.alphabet.Length;
              char letterEncoded = Globals.alphabet[newLetterPosition];
              encryptedMessage[i] = letterEncoded;
          }
      }
          // Output encrypted message
          string encodedString = String.Join("", encryptedMessage);
          Console.WriteLine($"Your encrypted message is: {encodedString}");
    
    }
    // Our method for decrypting messages
    static void Decrypt() {
      Console.Write("Enter a message to decrypt: ");
      string input = Console.ReadLine().ToLower(); // ensure message is lowercase
      char[] secretMessage = input.ToCharArray();  // turn message into an array
      // Array that will hold the decrypted message
      char[] decryptedMessage = new char[secretMessage.Length];
      // Loop through the message
      for (int i = 0; i < secretMessage.Length; i++) {
          // Checks for special characters like ! or ? and skips them
          char ch = secretMessage[i];
          bool alpha = Char.IsLetter(ch);
          if (alpha == false) {
            continue;
          }
          else {
              // Takes each character from the original message and moves them three places to the left in the alphabet to decrypt it
              char letter = secretMessage[i];
              int letterPosition = Array.IndexOf(Globals.alphabet, letter);
              // Set decryption key to 26-3 otherwise index position will be negative and an unhandled error exception will be thrown
              int newLetterPosition = (letterPosition + (26 - 3)) % Globals.alphabet.Length;
              char letterEncoded = Globals.alphabet[newLetterPosition];
              decryptedMessage[i] = letterEncoded;
          }
      }
          // Output decrypted message
          string decodedString = String.Join("", decryptedMessage);
          Console.WriteLine($"Your decrypted message is: {decodedString}");
      
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Encrypt or Decrypt?");
      string answer = Console.ReadLine().ToLower();

        if (answer == "encrypt") {
          Encrypt();
        }
        else if (answer == "decrypt") {
          Decrypt();
        }
        else {
          Console.WriteLine("Invalid answer.");
        }
    }

  }
}
