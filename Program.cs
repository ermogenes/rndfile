using System.Security.Cryptography;

int mbytes = Convert.ToInt32(args[1]) * 1024 * 1024;
var bytes = RandomNumberGenerator.GetBytes(mbytes);
File.WriteAllBytes(args[0], bytes);
