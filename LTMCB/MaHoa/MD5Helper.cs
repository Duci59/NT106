
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace LTMCB.MaHoa
{
    static class MD5Helper
    {
        static string matkhau = "1h87h8712j";
        public static string MaHoa(this string duLieuCanMaHoa)
        {
            byte[] input = Encoding.UTF8.GetBytes(duLieuCanMaHoa);
            byte[] output = bMaHoa(input);
            return Convert.ToBase64String(output, 0, output.Length);
        }

        public static string GiaiMa(this string duLieuCanGiaiMa)
        {
            byte[] input = Convert.FromBase64String(duLieuCanGiaiMa);
            byte[] output = bGiaiMa(input);
            return Encoding.UTF8.GetString(output);
        }
        public static string MaHoaMotChieu(this string duLieuCanMaHoa)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(duLieuCanMaHoa);
                byte[] hash = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2")); // Chuyển byte thành chuỗi hex
                }

                return sb.ToString();
            }
        }

        static byte[] bMaHoa(byte[] duLieuCanMaHoa)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
                {
                    des.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(matkhau));
                    des.Mode = CipherMode.ECB;
                    des.Padding = PaddingMode.PKCS7;
                    using (ICryptoTransform tran = des.CreateEncryptor())
                    {
                        byte[] output = tran.TransformFinalBlock(duLieuCanMaHoa, 0, duLieuCanMaHoa.Length);
                        return output;
                    }
                }
            }
        }

        static byte[] bGiaiMa(byte[] duLieuCanGiaiMa)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
                {
                    des.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(matkhau));
                    des.Mode = CipherMode.ECB;
                    des.Padding = PaddingMode.PKCS7;
                    using (ICryptoTransform tran = des.CreateDecryptor())
                    {

                        byte[] output = tran.TransformFinalBlock(duLieuCanGiaiMa, 0, duLieuCanGiaiMa.Length);
                        return output;
                    }
                }
            }
        }
        public static void EncryptWavFile(string inputFile, string outputFile)
        {
            // Generate key and IV from password
            byte[] key = GenerateKeyFromPassword(matkhau);
            byte[] iv = GenerateIVFromPassword(matkhau);

            // Đọc dữ liệu từ file âm thanh đầu vào
            byte[] inputBytes = File.ReadAllBytes(inputFile);

            // Mã hóa dữ liệu âm thanh sử dụng AES-GCM
            byte[] encryptedBytes = EncryptBytes(inputBytes, key, iv);

            // Ghi dữ liệu đã mã hóa vào file đầu ra
            File.WriteAllBytes(outputFile, encryptedBytes);
        }

        private static byte[] EncryptBytes(byte[] inputBytes, byte[] key, byte[] iv)
        {
            // Sử dụng AES-GCM với BouncyCastle
            GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
            AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv);

            cipher.Init(true, parameters);

            byte[] output = new byte[cipher.GetOutputSize(inputBytes.Length)];
            int outputLength = cipher.ProcessBytes(inputBytes, 0, inputBytes.Length, output, 0);
            cipher.DoFinal(output, outputLength);

            // Return encrypted data
            return output;
        }


        // con cai nay la giai ma 
        public static void DecryptWavFile(string inputFile, string outputFile)
        {
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.FullName;
            

            // Generate key and IV from password
            byte[] key = GenerateKeyFromPassword(matkhau);
            byte[] iv = GenerateIVFromPassword(matkhau);

            // Đọc dữ liệu từ file âm thanh đầu vào
            byte[] inputBytes = File.ReadAllBytes(inputFile);

            // Giải mã dữ liệu âm thanh sử dụng AES-GCM
            byte[] decryptedBytes = DecryptBytes(inputBytes, key, iv);

            // Ghi dữ liệu đã giải mã vào file đầu ra
            File.WriteAllBytes(outputFile, decryptedBytes);
        }

        private static byte[] DecryptBytes(byte[] inputBytes, byte[] key, byte[] iv)
        {
            // Sử dụng AES-GCM với BouncyCastle
            GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
            AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv);

            cipher.Init(false, parameters);

            byte[] output = new byte[cipher.GetOutputSize(inputBytes.Length)];
            int outputLength = cipher.ProcessBytes(inputBytes, 0, inputBytes.Length, output, 0);
            cipher.DoFinal(output, outputLength);

            // Return decrypted data
            return output;
        }
        static byte[] GenerateKeyFromPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        static byte[] GenerateIVFromPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                byte[] iv = new byte[16];
                Array.Copy(hash, iv, iv.Length);
                return iv;
            }
        }
    }
}
