using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextInImage
{
    class AwsAuthentication
    {
        public static AWSCredentials awsCredentials;
        public static readonly RegionEndpoint region = RegionEndpoint.USEast1;

        public static void SetCredentials()
        {
            CredentialProfileStoreChain chain = new CredentialProfileStoreChain();
            if (!chain.TryGetAWSCredentials("Aws Aula", out awsCredentials))
            {
                throw new Exception("Deu problema na autenticação");
            }
        }

    }
}
