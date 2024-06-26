﻿using System;
using System.Security.Cryptography;
using System.Text;

public class Test
{
	public static string ComputeMd5Hash(string message)
	{
		using (MD5 md5 = MD5.Create())
		{
			byte[] input = Encoding.ASCII.GetBytes(message);
			byte[] hash = md5.ComputeHash(input);

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("X2"));
			}
			return sb.ToString();
		}
	}
	public static void Main()
	{
		string message = "Welcome to DelfStack";
		Console.WriteLine(ComputeMd5Hash(message));
	}
}