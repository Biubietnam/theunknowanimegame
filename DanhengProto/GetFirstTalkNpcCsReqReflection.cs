using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006AC RID: 1708
	public static class GetFirstTalkNpcCsReqReflection
	{
		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x000CF783 File Offset: 0x000CD983
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkNpcCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001E44 RID: 7748
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRGaXJzdFRhbGtOcGNDc1JlcS5wcm90byIrChRHZXRGaXJzdFRhbGtO" + "cGNDc1JlcRITCgtucGNfaWRfbGlzdBgOIAMoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkNpcCsReq), GetFirstTalkNpcCsReq.Parser, new string[]
			{
				"NpcIdList"
			}, null, null, null, null)
		}));
	}
}
