# AWS Configuration

## Setting Up AWS Credentials

This application uses the AWS SDK for .NET, which follows the standard AWS credential provider chain. **Never hardcode credentials in source code.**

### Recommended Options (in order of precedence):

#### 1. Environment Variables (Recommended for Development)
Set these environment variables:
```powershell
$env:AWS_ACCESS_KEY_ID="your-access-key-id"
$env:AWS_SECRET_ACCESS_KEY="your-secret-access-key"
$env:AWS_REGION="us-east-1"
```

#### 2. AWS Credentials File (Recommended for Local Development)
Create or edit `~/.aws/credentials`:
```ini
[default]
aws_access_key_id = your-access-key-id
aws_secret_access_key = your-secret-access-key
```

And `~/.aws/config`:
```ini
[default]
region = us-east-1
```

#### 3. IAM Roles (Recommended for Production)
When running on AWS infrastructure (EC2, ECS, Lambda), use IAM roles instead of credentials.

### Security Best Practices

1. **Never commit credentials to source control**
2. Use AWS Secrets Manager or Parameter Store for production
3. Rotate credentials regularly
4. Use least-privilege IAM policies
5. Consider using AWS IAM Identity Center (SSO) for temporary credentials

### Testing Configuration

To verify your credentials are configured correctly:
```powershell
aws sts get-caller-identity
```

Or use the AWS Tools for PowerShell:
```powershell
Get-AWSCredential -ListProfileDetail
```
