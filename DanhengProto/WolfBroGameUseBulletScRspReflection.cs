using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001432 RID: 5170
	public static class WolfBroGameUseBulletScRspReflection
	{
		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x002650FA File Offset: 0x002632FA
		public static FileDescriptor Descriptor
		{
			get
			{
				return WolfBroGameUseBulletScRspReflection.descriptor;
			}
		}

		// Token: 0x04005B89 RID: 23433
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Xb2xmQnJvR2FtZVVzZUJ1bGxldFNjUnNwLnByb3RvGhVXb2xmQnJvR2Ft",
			"ZURhdGEucHJvdG8iWgoZV29sZkJyb0dhbWVVc2VCdWxsZXRTY1JzcBIsChJ3",
			"b2xmX2Jyb19nYW1lX2RhdGEYCSABKAsyEC5Xb2xmQnJvR2FtZURhdGESDwoH",
			"cmV0Y29kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WolfBroGameUseBulletScRsp), WolfBroGameUseBulletScRsp.Parser, new string[]
			{
				"WolfBroGameData",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
