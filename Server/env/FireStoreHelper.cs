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
          ""project_id"": ""chatandload-28b59"",
          ""private_key_id"": ""8a44672a8639c03a7f6c507ca54b738ffc5a8517"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQC9/syfuavdwgpr\nTapCNVNAV9DhJQV0bIuh+CIx5ANk4O/v4JDsT42+0y4dmZ4eQu5EfdemiRvmrh72\naewzISon7hzN2ufKAZnKsxtDlo3Nzlzx2GmBBzVwaoWI7f3gC38Mk1R08pwZFVQa\nsVFN6HCj7/ck9CHYsmKPWPSSIT2V/UaCO/Voq+w/sxG7y1fqaG7dURYmTDZu1tlO\nUVX/TlLQeu+BaRJLns5oUk9J0ZgcThVtdEI4cvAPCy3xDwindN0SoslzctlDfyx2\nETpDsh3Cph2SEkrw7SgN9kq7wq4owlU4PwXUfd+49Q80jzcVFpIaJMLhP9EKGpEd\n99E6ISczAgMBAAECggEADEcc29q735xyxh6VnypJNniJf+5ZOcq36hNNL/8sAi1d\nCmaiYHr/NHLHx9O0OZozdPHS6UKllTskUHuY1XCe6kfdAA28E9Xicj+WLMB1nado\nlZvzRj2Vt2C5P2RUMLgqRI3fk9OHwQ4CF0JLkdn9Yw9835wp9Phvt3nupOQI0ecY\nmcG/VIWVyGXgbIozYcVLRckc1Kp4BC1+5MQjmVxkMUNGq8l++hCRRBAEQ//CTTlJ\nmRtyao2PAHAQ5pKfrYaVjDsbwnOsKo16noppyBvXVdyjw9BO29AvQHXkN0rrFL4z\neJ7aclK8i6D830w+ZhZ+HVgYUmIe4G36xlKuGnKqQQKBgQDxpNiXakGmfQNh2jaS\naaGmvs8vaQDT9KuVACJ/yIn4IPc1IymIV7E0oBjrSg3Hv4D69vaJKO3WgKsHm0Tb\nWDwkq4IvGRMxna0X1rfSq8cG2/a4UzWt0EAMa9OaEXu8Tx6YE8sMUtGn5AKZG1vA\nov1bnBkjfGfb6Z84zY6imhnWwQKBgQDJSG5kvdgwfwYscA3BWh84K+EWKVyuANIM\nZ/e/Te/ffav0HZiJmTyK/ScfLEVMQAdqXL/9YMljyRoc/+3WeVsGlZiEybD5Mg+9\nCINqBBr5G0N9UxInTwZGlyfajMuBzrrfAnli+3gGGRM95T7kuUN1kqa56Eoe3NaF\n9rQyDovO8wKBgFid3ZhZrU3DFtRx1AWJm3CtFQoL9fPFDI+OBxjZkE9gt4fTJ04K\n6r+j3r+a3sbcIg7nNq5CRkad1RrrBCt0hknkY8+l4HYXnvzZD3zA5jJLxIUAbvUZ\nJAPqHyWnN7ttQIkA6TvRu3VYluNTNyjEHSnVaxqqauQpHu0T5TUYUlWBAoGAJ0wP\n2XVDDvzNvMFHvjcVH0dZ05TRtlsMp0VpFh1mNpD3kFpy3HJhYpVYHPrssJ1TlU10\nYkiSKPwrL/w7eAMLZXaxZ0NlXNGMRxCxb3JLvdS30XD1e10vUXrTWhTg6n/s9fsq\nrcuAvFgK7KukIs2UwRCXonYaenoNG+x1c8xpOUcCgYBNqH2TVCCIjDuPyu5xWDWB\nXdZ9cdmg2690pu7+gz+rb8TcfV86g3mcg5K3JFjCzHyEXZI/4gsURSCFKbpvHqXl\nw4o5m1kEYAghamqVZ/LEfcSPODu8peUBu8+I1Zzd1jVuE5/FBLOol5SDuHIXe3UU\nJiEoM8CnfAwcb/EaL1j11w==\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-wq3oc@chatandload-28b59.iam.gserviceaccount.com"",
          ""client_id"": ""109364181868352815808"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-wq3oc%40chatandload-28b59.iam.gserviceaccount.com"",
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
            db = FirestoreDb.Create("chatandload-28b59");
            File.Delete(filepath);
        }

    }
}