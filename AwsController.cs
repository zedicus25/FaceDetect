using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

using System.Collections.Generic;
using System;
using Amazon.S3;
using Amazon.S3.Model;

namespace Aws
{
    public class AwsController
    {
        private AmazonS3Client _s3Client;
        private AmazonRekognitionClient _amazonRekognition;
        private readonly string _bucketName;
        private readonly RegionEndpoint _region;

        public AwsController()
        {
            string accesKey = "";
            string secretKey = "";
            _bucketName = "rekig";
            _region = RegionEndpoint.EUWest2;
            _s3Client = new AmazonS3Client(accesKey, secretKey, _region);
            _amazonRekognition = new AmazonRekognitionClient(accesKey, secretKey, _region);
        }

        public bool UploadFile(string fileName, string filePath)
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = fileName,
                FilePath = filePath,
            };
            var response = _s3Client.PutObject(request);
            return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
        }

        public List<BoundingBox> DetectFaces(string pic)
        {
            DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
            {
                Image = new Amazon.Rekognition.Model.Image()
                {
                    S3Object = new Amazon.Rekognition.Model.S3Object()
                    {
                        Name = pic,
                        Bucket = _bucketName
                    }
                }
            };
            List<BoundingBox> boundingBoxes = new List<BoundingBox>();

            try
            {
                DetectFacesResponse detectFacesResponse = _amazonRekognition.DetectFacesAsync(detectFacesRequest).GetAwaiter().GetResult();
                bool hasAll = detectFacesRequest.Attributes.Contains("ALL");


                foreach (FaceDetail face in detectFacesResponse.FaceDetails)
                {
                    boundingBoxes.Add(face.BoundingBox);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return boundingBoxes;

        }

    }
}