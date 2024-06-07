using System;
using System.Text;
using System.Security.Cryptography;
/// <summary>
/// Klasa odpowiedzialna za hashowanie i weryfikację haseł przy użyciu algorytmu MD5
/// </summary>
public class PasswordHashing {
    public static string CalculateMD5Hash(string input) {
        using (MD5 md5 = MD5.Create()) {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++) {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
    
    public static bool VerifyMD5Hash(string input, string hash) {
        string hashOfInput = CalculateMD5Hash(input);
        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        return stringComparer.Compare(hashOfInput, hash) == 0;
    }
}