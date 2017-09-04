using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

public class ClsCrypto
{
	private const  _defaultpassword = "m@s1eweencrypt1onm@sj1en";
	//Byte vector required for Rijndael.  This is randomly generated and recommended you change it on a per-application basis.
	//It is 16 bytes.
	private byte[] bytIV = {
		121,
		241,
		10,
		1,
		132,
		74,
		11,
		39,
		255,
		91,
		45,
		78,
		14,
		211,
		22,
		62

	};
	//Character to pad keys with to make them at least intMinKeySize.

	private const char chrKeyFill = Convert.ToChar("X");
	//String to display on error for functions that return strings. {0} is Exception.Message.

	private const string strTextErrorString = "#ERROR - {0}";
	//Min size in bytes of randomly generated salt.

	private const int intMinSalt = 4;
	//Max size in bytes of randomly generated salt.

	private const int intMaxSalt = 8;
	//Size in bytes of Hash result.  MD5 returns a 128 bit hash.

	private const int intHashSize = 16;
	//Size in bytes of the key length.  Rijndael takes either a 128, 192, or 256 bit key.  
	//If it is under this, pad with chrKeyFill. If it is over this, truncate to the length.

	private const int intKeySize = 32;
	//Encrypt a String with Rijndael symmetric encryption.
	// String128Bit
	public string kodeer128(string strPlainText)
	{
		try {
			byte[] bytPlainText = null;
			byte[] bytKey = null;
			byte[] bytEncoded = null;
			MemoryStream objMemoryStream = new MemoryStream();
			RijndaelManaged objRijndaelManaged = new RijndaelManaged();

			strPlainText = strPlainText.Replace(Constants.vbNullChar, string.Empty);

			bytPlainText = Encoding.UTF8.GetBytes(strPlainText);
			bytKey = ConvertKeyToBytes(_defaultpassword);

			CryptoStream objCryptoStream = new CryptoStream(objMemoryStream, objRijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);

			objCryptoStream.Write(bytPlainText, 0, bytPlainText.Length);
			objCryptoStream.FlushFinalBlock();

			bytEncoded = objMemoryStream.ToArray();
			objMemoryStream.Close();
			objCryptoStream.Close();

			return Convert.ToBase64String(bytEncoded);
		} catch (Exception ex) {
			return string.Format(strTextErrorString, ex.Message);
		}
	}

	//Decrypt a String with Rijndael symmetric encryption.
	public string Dekodeer128(string strCryptText)
	{
		try {
			byte[] bytCryptText = null;
			byte[] bytKey = null;

			RijndaelManaged objRijndaelManaged = new RijndaelManaged();

			bytCryptText = Convert.FromBase64String(strCryptText);
			bytKey = ConvertKeyToBytes(_defaultpassword);

			byte[] bytTemp = new byte[bytCryptText.Length + 1];
			MemoryStream objMemoryStream = new MemoryStream(bytCryptText);

			CryptoStream objCryptoStream = new CryptoStream(objMemoryStream, objRijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Read);

			objCryptoStream.Read(bytTemp, 0, bytTemp.Length);

			objMemoryStream.Close();
			objCryptoStream.Close();

			return Encoding.UTF8.GetString(bytTemp).Replace(Constants.vbNullChar, string.Empty);

		} catch (Exception ex) {
			return string.Format(strTextErrorString, ex.Message);
		}

	}

	//Compute an MD5 hash code from a string and append any salt-bytes used/generated to the end.
	public string ComputeMD5Hash(string strPlainText, [System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute(null)]  // ERROR: Optional parameters aren't supported in C#
byte[] bytSalt)
	{
		try {
			byte[] bytPlainText = Encoding.UTF8.GetBytes(strPlainText);
			HashAlgorithm hash = new MD5CryptoServiceProvider();

			if (bytSalt == null) {
				Random rand = new Random();
				int intSaltSize = rand.Next(intMinSalt, intMaxSalt);

				bytSalt = new byte[intSaltSize];

				RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
				rng.GetNonZeroBytes(bytSalt);
			}

			byte[] bytPlainTextWithSalt = new byte[bytPlainText.Length + bytSalt.Length];

			bytPlainTextWithSalt = ConcatBytes(bytPlainText, bytSalt);

			byte[] bytHash = hash.ComputeHash(bytPlainTextWithSalt);
			byte[] bytHashWithSalt = new byte[bytHash.Length + bytSalt.Length];

			bytHashWithSalt = ConcatBytes(bytHash, bytSalt);

			return Convert.ToBase64String(bytHashWithSalt);
		} catch (Exception ex) {
			return string.Format(strTextErrorString, ex.Message);
		}
	}

	//Verify a string against a hash generated with the ComputeMD5Hash function above.
	public bool VerifyHash(string strPlainText, string strHashValue)
	{
		try {
			byte[] bytWithSalt = Convert.FromBase64String(strHashValue);

			if (bytWithSalt.Length < intHashSize)
				return false;

			byte[] bytSalt = new byte[bytWithSalt.Length - intHashSize];

			Array.Copy(bytWithSalt, intHashSize, bytSalt, 0, bytWithSalt.Length - intHashSize);

			string strExpectedHashString = ComputeMD5Hash(strPlainText, bytSalt);

			return strHashValue.Equals(strExpectedHashString);
		} catch (Exception ex) {
			return null;
		}
	}

	//Simple function to concatenate two byte arrays. 
	private byte[] ConcatBytes(byte[] bytA, byte[] bytB)
	{
		try {
			byte[] bytX = new byte[((bytA.Length + bytB.Length))];

			Array.Copy(bytA, bytX, bytA.Length);
			Array.Copy(bytB, 0, bytX, bytA.Length, bytB.Length);

			return bytX;
		} catch (Exception ex) {
			return null;
		}

	}

	//A function to convert a string into a 32 byte key. 
	private byte[] ConvertKeyToBytes(string strKey)
	{
		try {
			int intLength = strKey.Length;

			if (intLength < intKeySize) {
				strKey += Strings.StrDup(intKeySize - intLength, chrKeyFill);
			} else {
				strKey = strKey.Substring(0, intKeySize);
			}

			return Encoding.UTF8.GetBytes(strKey);
		} catch (Exception ex) {
			return null;
		}
	}

}

