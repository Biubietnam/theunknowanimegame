using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200142E RID: 5166
	public static class WolfBroGamePickupBulletScRspReflection
	{
		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x00264999 File Offset: 0x00262B99
		public static FileDescriptor Descriptor
		{
			get
			{
				return WolfBroGamePickupBulletScRspReflection.descriptor;
			}
		}

		// Token: 0x04005B7A RID: 23418
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJXb2xmQnJvR2FtZVBpY2t1cEJ1bGxldFNjUnNwLnByb3RvGhVXb2xmQnJv",
			"R2FtZURhdGEucHJvdG8iXQocV29sZkJyb0dhbWVQaWNrdXBCdWxsZXRTY1Jz",
			"cBIsChJ3b2xmX2Jyb19nYW1lX2RhdGEYAyABKAsyEC5Xb2xmQnJvR2FtZURh",
			"dGESDwoHcmV0Y29kZRgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WolfBroGamePickupBulletScRsp), WolfBroGamePickupBulletScRsp.Parser, new string[]
			{
				"WolfBroGameData",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
