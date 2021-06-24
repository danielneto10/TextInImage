using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextInImage
{
    class RekognitionUtils
    {

        public async Task<DetectTextResponse> DetectTextInImage(string fileImage, string bucketName)
        {
            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient(AwsAuthentication.awsCredentials, AwsAuthentication.region);

            DetectTextRequest detectTextRequest = new DetectTextRequest()
            {
                Image = new Image()
                {
                    S3Object = new S3Object()
                    {
                        Name = Path.GetFileName(fileImage),
                        Bucket = bucketName
                    }

                },
                Filters = new DetectTextFilters()
                {
                    WordFilter = new DetectionFilter()
                    {
                        MinConfidence = 80
                    }
                }
            };

            try
            {
                DetectTextResponse detectTextResponse = await rekognitionClient.DetectTextAsync(detectTextRequest);
                return detectTextResponse;
            }
            catch (AmazonRekognitionException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
