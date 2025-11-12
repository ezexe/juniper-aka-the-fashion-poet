namespace Juniper.Core.AWS.S3
{
    public class S3BucketService
    {
        public const string SaveBucketName = "saved/";
        public static S3BucketService Current { get; private set; }

        // If the AWS Region defined for your default user is different
        // from the Region where your Amazon S3 bucket is located,
        // pass the Region name to the Amazon S3 client object's constructor.
        // For example: RegionEndpoint.USWest2 or RegionEndpoint.USEast2.
        readonly IAmazonS3 client;

        string bucketName => SettingsViewModel.StateofSandbox ? "juniperapptests" : "juniperapp";
        public S3BucketService()
        {
            Current = this;

            // Uses AWS credential provider chain (environment variables, AWS credentials file, IAM role, etc.)
            client = new AmazonS3Client(
                new AmazonS3Config
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                    UseAccelerateEndpoint = !SettingsViewModel.StateofSandbox
                });
        }

        /// <summary>
        /// Uses an Amazon S3 multipart transfer to upload all of the text files in
        /// a local directory to an Amazon S3 bucket.
        /// </summary>
        /// <param name="client">The initialized Amazon S3 client object used to
        /// perform the multipart upload.</param>
        /// <param name="bucketName">The name of the bucket to which the files
        /// will be uploaded from the local directory.</param>
        /// <param name="directoryPath">The path of the local directory that
        /// contains the files to upload to the Amazon S3 bucket.</param>
        /// <param name="wildCard">The wild card used to filter the files to
        /// be uploaded.</param>
        public async Task<string?> UploadDirAsync(
            string directoryPath,
            string bucketDir,
            string keyPrefix,
            string wildCard = "*.*")
        {
            try
            {
                MainViewModel.Current.DisplayInfobarMessage("Uploading Dir...", directoryPath, InfoSeverity.Informational);

                var directoryTransferUtility = new TransferUtility(client);

                // Upload the entire contents of a local directory to an S3
                // bucket.
                //await directoryTransferUtility.UploadDirectoryAsync(
                //    directoryPath,
                //    bucketName);
                //Debug.WriteLine("Upload statement 1 completed");

                // Upload only the text files from a local directory using a
                // recursive search to find text files in child directories.
                //await directoryTransferUtility.UploadDirectoryAsync(
                //                               directoryPath,
                //                               bucketName,
                //                               wildCard,
                //                               SearchOption.AllDirectories);
                //Debug.WriteLine("Upload statement 2 completed");

                // Performs the same as before using the
                // TransferUtilityUploadDirectoryRequest instead of individual
                // parameters.
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = $"{bucketName}/{bucketDir}",
                    Directory = directoryPath,
                    KeyPrefix = keyPrefix,
                    SearchOption = SearchOption.AllDirectories,
                    SearchPattern = wildCard,
                };
                await directoryTransferUtility.UploadDirectoryAsync(request); 

                MainViewModel.Current.DisplayInfobarMessage("Complete", directoryPath, InfoSeverity.Success);

                return $"{bucketDir}/{keyPrefix}";
            }
            catch (AmazonS3Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, "AmazonS3Exception in UploadDirAsync");
            }
            catch (Exception ee)
            {
                MainViewModel.Current.LoggerUtil.AddException(ee, "Exception in UploadDirAsync");
            }
            return null;
        }

        /// <summary>
        /// This method uploads a file to an Amazon S3 bucket using a TransferUtility
        /// object.
        /// </summary>
        /// <param name="bucketName">The name of the bucket to which to upload
        /// the file.</param>
        /// <param name="keyName">The file name to be used in the
        /// destination Amazon S3 bucket.</param>
        /// <param name="filePath">The path, including the file name of the
        /// file to be uploaded to the Amazon S3 bucket.</param>
        public async Task UploadFileAsync(
            string filePath,
            string bucketDir,
            string keyName)
        {
            try
            {
                MainViewModel.Current.DisplayInfobarMessage("Uploading...", filePath, InfoSeverity.Informational);

                var fileTransferUtility = new TransferUtility(client);

                // Upload a file. The file name is used as the object key name.
                // await fileTransferUtility.UploadAsync(filePath, Path.Combine(bucketName, bucketDir));

                // Specify object key name explicitly.
                await fileTransferUtility.UploadAsync(filePath, $"{bucketName}/{bucketDir}", keyName);

                MainViewModel.Current.DisplayInfobarMessage("Complete", filePath, InfoSeverity.Success);

                // Upload data from a System.IO.Stream object.
                //using (var fileToUpload =
                //    new FileStream(filePath, FileMode.Open, FileAccess.Read))
                //{
                //    await fileTransferUtility.UploadAsync(
                //        fileToUpload,
                //        bucketName,
                //        keyName);
                //}
                //Console.WriteLine("Upload 3 completed");

                // Option 4. Specify advanced settings.
                //var fileTransferUtilityRequest = new TransferUtilityUploadRequest
                //{
                //    BucketName = bucketName,
                //    FilePath = filePath,
                //    StorageClass = S3StorageClass.Standard,
                //    PartSize = 6291456, // 6 MB.
                //    Key = keyName,
                //    CannedACL = S3CannedACL.PublicRead,
                //};

                //fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
                //fileTransferUtilityRequest.Metadata.Add("param2", "Value2");

                //await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);
                //Console.WriteLine("Upload 4 completed");
            }
            catch (AmazonS3Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, "AmazonS3Exception in UploadFileAsync");
                //Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ee)
            {
                MainViewModel.Current.LoggerUtil.AddException(ee, "Exception in UploadFileAsync");
            }
        }

        /// <summary>
        /// Uses the client object to get a list of the objects in the Amazon
        /// S3 bucket in the bucketName parameter.
        /// </summary>
        /// <param name="client">The initialized Amazon S3 client object used to call
        /// the ListObjectsAsync method.</param>
        /// <param name="bucketName">The bucket name for which you want to
        /// retrieve a list of objects.</param>
        public async Task ListingObjectsAsync(string bucketDir)
        {
            try
            {
                ListObjectsV2Request request = new()
                {
                    BucketName = $"{bucketName}",
                    MaxKeys = 5,
                };

                var response = new ListObjectsV2Response();

                do
                {
                    response = await client.ListObjectsV2Async(request);

                    //response.S3Objects
                    //    .ForEach(async obj => await ReadObjectDataAsync(bucketDir, obj.Key, savetodir));

                    // If the response is truncated, set the request ContinuationToken
                    // from the NextContinuationToken property of the response.
                    request.ContinuationToken = response.NextContinuationToken;
                } while (response.IsTruncated);
            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine($"Error encountered on server. Message:'{ex.Message}' getting list of objects.");
            }
        }
        public async Task SaveObjectDirectory(string bucketDir,  string savetodir)
        {
            try
            {
                var request = new ListObjectsV2Request
                {
                    BucketName = $"{bucketName}",
                    Prefix = $"{bucketDir}/",
                    MaxKeys = 1000
                };

                var response = await client.ListObjectsV2Async(request);
                var utility = new TransferUtility(client);

                foreach (var obj in response.S3Objects)
                {
                    var f = $"{savetodir}\\{obj.Key.Substring(obj.Key.LastIndexOf("/")+1)}";
                    if (File.Exists(f))
                        File.Delete(f);
                    utility.Download(f, bucketName, obj.Key);
                }
            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine($"Error encountered on server. Message:'{ex.Message}' getting list of objects.");
            }
        }

        /// <summary>
        /// This method copies the contents of the object keyName to another
        /// location, for example, to your local system.
        /// </summary>
        /// <param name="bucketName">The name of the Amazon S3 bucket which contains
        /// the object to copy.</param>
        /// <param name="keyName">The name of the object you want to copy.</param>
        public async Task<string> ReadObjectDataAsync(
            string bucketDir, 
            string keyName,
            string? savetodir = null)
        {
            MainViewModel.Current.DisplayInfobarMessage("Reading...", $"{bucketDir} - {keyName}", InfoSeverity.Informational);
            // snippet-start:[S3.dotnetv3.GetObjectExample]
            string responseBody = string.Empty;

            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = $"{bucketName}/{bucketDir}",
                    Key = keyName,
                };

                using (GetObjectResponse response = await client.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                {
                    // Write the contents of the file to disk.
                    if (savetodir != null)
                    {
                        if (!Directory.Exists(savetodir)) 
                            Directory.CreateDirectory(savetodir);
                        
                        string filePath = $"{savetodir}\\{keyName}";

                        using var br = new BinaryReader(responseStream);
                        var bytes = br.ReadBytes((int)responseStream.Length);
                        await File.WriteAllBytesAsync(filePath, bytes);
                    }

                    // Retrieve the contents of the file.
                    using StreamReader reader = new(responseStream);

                    // Assume you have "title" as medata added to the object.
                    //string title = response.Metadata["x-amz-meta-title"];
                    //string contentType = response.Headers["Content-Type"];

                    responseBody = reader.ReadToEnd();
                }
                MainViewModel.Current.DisplayInfobarMessage("Complete", $"{bucketDir} - {keyName}", InfoSeverity.Success);
            }
            catch (AmazonS3Exception e)
            {
                // If the bucket or the object do not exist
                MainViewModel.Current.LoggerUtil.AddException(e, "AmazonS3Exception in ReadObjectDataAsync");
                MainViewModel.Current.DisplayInfobarMessage("AmazonS3Exception", $"{bucketDir} - {keyName} {Environment.NewLine} {e.StackTrace}", InfoSeverity.Success);
            }

            return responseBody;
        }

        public async Task<Stream?> GetObjectStreamAsync(string bucketDir, string keyName)
        {
            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = $"{bucketName}/{bucketDir}",
                    Key = keyName,
                };

                using GetObjectResponse response = await client.GetObjectAsync(request);
                return response.ResponseStream;
            }
            catch (AmazonS3Exception e)
            {
                // If the bucket or the object do not exist
                MainViewModel.Current.LoggerUtil.AddException(e, "AmazonS3Exception in ReadObjectDataAsync");
            }

            return null;
        }
    }
}
