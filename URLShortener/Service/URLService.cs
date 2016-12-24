using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using URLShortener.Classes;
using URLShortener.Properties;

namespace URLShortener.Service
{
    public class UrlService
    {
        private static readonly Random Random = new Random();
        private static readonly string[] Adjectives = Regex.Split(Resources.Adjectives, "\r\n");
        private static readonly string[] Nouns = Regex.Split(Resources.Nouns, "\r\n");

        /// <summary>
        /// Generates an instance of UploadedUrl with a code and stores this in the database
        /// </summary>
        /// <param name="url">Url to shorten</param>
        /// <param name="readable">Whether the generated code should be human readable</param>
        /// <returns>Instance of uploaded url with a code attached to it, null if url was not valid</returns>
        public static UploadedUrl UploadUrl(string url, bool readable = true)
        {
            if (!ValidateUrl(url))
            {
                return null;
            }

            var result = new UploadedUrl
            {
                Url = url,
                ShortenedUrl = GenerateRandomName(readable)
            };

            using (var db = new UrlContext())
            {
                // if a duplicate name is found, loop until it's unique
                while (db.Urls.Any(x => x.ShortenedUrl.Equals(result.ShortenedUrl)))
                {
                    result.ShortenedUrl = GenerateRandomName(readable);
                }

                db.Urls.Add(result);
                db.SaveChanges();
            }


            return result;
        }

        /// <summary>
        /// Attempts to find an uploaded URL based on a given code
        /// </summary>
        /// <param name="code">Code to look for</param>
        /// <returns>UploadedUrl object that corresponds to the found upload, otherwise null</returns>
        public static UploadedUrl FindUrl(string code)
        {
            using (var db = new UrlContext())
            {
                var result = db.Urls.Find(code);

                if (result != null)
                {
                    result.Clicks++;
                    db.SaveChanges();
                }
                
                return result;
            }
        }

        public static string GenerateRandomName(bool readable = true)
        {
            var sb = new StringBuilder();

            if (readable)
            {
                // Generate a random readable url based on X adjectives and Y nouns
                for (var i = 0; i < Config.AdjectiveCount; i++)
                {
                    sb.Append(Adjectives[Random.Next(Adjectives.Length)]);
                }

                for (var i = 0; i < Config.NounCount; i++)
                {
                    sb.Append(Nouns[Random.Next(Nouns.Length)]);
                }
            }
            else
            {
                // Generate a random unreadable url
                for (var i = 0; i < Config.UrlLength; i++)
                {
                    sb.Append(Config.Charset[Random.Next(Config.Charset.Length)]);
                }
            }

            return sb.ToString();

        }

        public static bool ValidateUrl(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
