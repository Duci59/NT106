using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.env
{
    public class FireStoreHelper
    {
        static string fireconfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""chatandload"",
          ""private_key_id"": ""ef5dbe15ad750b19720a3a6fda342934aeec6a3f"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDZJhAfSb8+RSZB\nuOGEzBfj3EpcZsFI5sE5aYtCtQs9whI49Y2nTODuLK6GNtXbNutPpT4yLwFTJEDX\n9hdwnKIbKcxU3c4w6P2iw5sm0b7q58DoqBbSrkdPc8uvTR/MTYSS+IZ7WJb/9ydR\n9kozeZYntTa0pCavYE6effLPorcPHCyXwo4OBWwbHmHkUr+o8qw5jK65jsC6Xy32\nU9w31krSEnZoMD2Lj4RaHDk1EFqCkHO9ZGOlrVpWkthKrIpRF/0hrS4Jd/qm7OPU\ncAQNlpc8NYGpk6wyRlFfkpPBtnsUvByUysBlrj07CJUC9iCrcaGVkTvqQFlGIyJ4\n7zaswow/AgMBAAECggEAA2azuPG8Q5rsqvnc2moh86k3JvRbEau/mgkbq8tPJkP8\nahT6h4TOPxzHDQYd2mWlUOWLMFkJIca/F0LdAiAJ7/f7IdcpjB2SH3MF4plFbsN7\ng4lidiFRr55mMdQ468fJDE5FOPhdwRuba466gczlO7D8bt7lVjjhcl0RqQvo5x0n\n9n8cJPZTRtuCI4wadcsbXY8PhoC/0UTAuV9acxjCJSAdw7CN36a7rpCNLL5vpC8D\nBDi2ecPrQJ7GoNC+KhOLF95QO79/RaAPszQK7AR3cvSGiSxdZRDN04c2gc881urR\ngeqFF3tdU3xp6rJiz3qcdkIolCA+PyoLKLoUrpy6+QKBgQD30LrasBtndaw0NDTg\nuvpHjof3Q4sxA2eDB0qoa7Qa3FqyvKrPkydzGoubdNC16axjXL2OJlC1JaG4WWDN\n1eTgykqhXxFgC72vdYWoXS3FQphyAfm4bNjo4xW1+l6cHEpQF4DRkCwFcs2P118r\n8K0eWa6a3tNOdvsqF3079JfziQKBgQDgUgwnkKw79yzZQVOc3d4q5IWBk595w4tP\nIGVlkDpRaD916Irmf+yJIZRsDGjyIMVWxbj9h74nHTuhen4+NbFCpRf0xWb5GEut\nwhzUIUlnwQIRGfjUHamJ0mSqpd0iJIwg2Y6DeH8l/Oq9kUQIF0+wCDs0HU1Gz5Uf\nd7S21j1nhwKBgQCs60cXBb95h9CrdKpZDd9KQxh43vanMrrt4Q6lStIX1B6tjZya\nzxG97Y3w4ago527Uvoe+QtoaLLIV0rgLqO7WNBGzXIThQhAP+K9U9f/UH04Eb4By\nwfDxQFOL8bJGuC7aiCvpDvLIsnzhm+Ta4kvKW8XMZyOHItrLWiyWw2usEQKBgCJP\nalyC3FUvsURpoYhUxy54VZNEKRhOuHgZ1Gh8bu8UquA1+UjYOC2hXTpJi6O9L3He\nPDVLFeKVrhE80yJgxAQVjFx79QwUkz64egBYNwoPk2laN5z6DHxwGcWgKPqX7Hb5\nz7p8K7Z7wMvN9EHojt+14phOAwvZpE1z2cg9bJbxAoGAZotV+BEbyjvyKfWyeGAN\nf2NKeDeFE7EyDnRXUatrbheX7ZBbIttzu6SBEHUCQAqLPk+bbTJavG9iorhVHblB\nyPurPmzZjybammLC3XMwlkQKmm7RJQod+t72HDzTvdIigZf0YX/C+cZMsKOfvWx4\nKgfDXWcV5rlzTNHuhsqnZsE=\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-52zg7@chatandload.iam.gserviceaccount.com"",
          ""client_id"": ""111811376174536157812"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-52zg7%40chatandload.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";
        public static FirestoreDb db { get; private set; }
        public static void SetEnviromentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            db = FirestoreDb.Create("chatandload");
            File.Delete(filepath);
        }

    }
}
