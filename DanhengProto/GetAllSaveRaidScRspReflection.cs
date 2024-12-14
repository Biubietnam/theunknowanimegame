using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000610 RID: 1552
	public static class GetAllSaveRaidScRspReflection
	{
		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000BEF12 File Offset: 0x000BD112
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAllSaveRaidScRspReflection.descriptor;
			}
		}

		// Token: 0x04001BE1 RID: 7137
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRBbGxTYXZlUmFpZFNjUnNwLnByb3RvGg5SYWlkRGF0YS5wcm90byJJ" + "ChNHZXRBbGxTYXZlUmFpZFNjUnNwEg8KB3JldGNvZGUYCyABKA0SIQoOcmFp" + "ZF9kYXRhX2xpc3QYBiADKAsyCS5SYWlkRGF0YUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RaidDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAllSaveRaidScRsp), GetAllSaveRaidScRsp.Parser, new string[]
			{
				"Retcode",
				"RaidDataList"
			}, null, null, null, null)
		}));
	}
}
