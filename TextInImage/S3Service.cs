using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextInImage
{
    class S3Service
    {
        private AmazonS3Client s3Client = new AmazonS3Client(AwsAuthentication.awsCredentials, AwsAuthentication.region);
        public async Task<bool> UploadToS3(string file, string bucketName)
        {
            try
            {
                TransferUtility transferUtility = new TransferUtility(s3Client);
                await transferUtility.UploadAsync(file, bucketName);
                return true;
            }
            catch (AmazonS3Exception)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<S3Bucket> GetListBuckets()
        {
            ListBucketsResponse listBuckets = s3Client.ListBucketsAsync().Result;
            return listBuckets.Buckets;
        }
    }
}
