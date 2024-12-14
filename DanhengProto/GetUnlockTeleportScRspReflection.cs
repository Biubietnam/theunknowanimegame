using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000842 RID: 2114
	public static class GetUnlockTeleportScRspReflection
	{
		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06005E0D RID: 24077 RVA: 0x000F9288 File Offset: 0x000F7488
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetUnlockTeleportScRspReflection.descriptor;
			}
		}

		// Token: 0x04002441 RID: 9281
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRVbmxvY2tUZWxlcG9ydFNjUnNwLnByb3RvIkcKFkdldFVubG9ja1Rl" + "bGVwb3J0U2NSc3ASHAoUdW5sb2NrX3RlbGVwb3J0X2xpc3QYCSADKA0SDwoH" + "cmV0Y29kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetUnlockTeleportScRsp), GetUnlockTeleportScRsp.Parser, new string[]
			{
				"UnlockTeleportList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
