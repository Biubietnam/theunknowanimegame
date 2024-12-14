using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E0 RID: 2016
	public static class GetSaveRaidCsReqReflection
	{
		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x000EFCA7 File Offset: 0x000EDEA7
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSaveRaidCsReqReflection.descriptor;
			}
		}

		// Token: 0x040022E8 RID: 8936
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTYXZlUmFpZENzUmVxLnByb3RvIjgKEEdldFNhdmVSYWlkQ3NSZXES" + "DwoHcmFpZF9pZBgKIAEoDRITCgt3b3JsZF9sZXZlbBgLIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSaveRaidCsReq), GetSaveRaidCsReq.Parser, new string[]
			{
				"RaidId",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}
