using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000768 RID: 1896
	public static class GetPlayerDetailInfoCsReqReflection
	{
		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x000E3EDC File Offset: 0x000E20DC
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPlayerDetailInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002148 RID: 8520
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRQbGF5ZXJEZXRhaWxJbmZvQ3NSZXEucHJvdG8iJwoYR2V0UGxheWVy" + "RGV0YWlsSW5mb0NzUmVxEgsKA3VpZBgIIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerDetailInfoCsReq), GetPlayerDetailInfoCsReq.Parser, new string[]
			{
				"Uid"
			}, null, null, null, null)
		}));
	}
}
