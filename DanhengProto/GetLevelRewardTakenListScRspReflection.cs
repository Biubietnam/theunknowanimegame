using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F6 RID: 1782
	public static class GetLevelRewardTakenListScRspReflection
	{
		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x000D7302 File Offset: 0x000D5502
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardTakenListScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F66 RID: 8038
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRMZXZlbFJld2FyZFRha2VuTGlzdFNjUnNwLnByb3RvIlAKHEdldExl" + "dmVsUmV3YXJkVGFrZW5MaXN0U2NSc3ASHwoXbGV2ZWxfcmV3YXJkX3Rha2Vu" + "X2xpc3QYDyADKA0SDwoHcmV0Y29kZRgGIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardTakenListScRsp), GetLevelRewardTakenListScRsp.Parser, new string[]
			{
				"LevelRewardTakenList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
