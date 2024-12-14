using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001400 RID: 5120
	public static class UpgradeAreaCsReqReflection
	{
		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x0600E455 RID: 58453 RVA: 0x0025F1D0 File Offset: 0x0025D3D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005AB4 RID: 23220
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZVcGdyYWRlQXJlYUNzUmVxLnByb3RvIjIKEFVwZ3JhZGVBcmVhQ3NSZXES" + "DQoFbGV2ZWwYDSABKA0SDwoHYXJlYV9pZBgFIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaCsReq), UpgradeAreaCsReq.Parser, new string[]
			{
				"Level",
				"AreaId"
			}, null, null, null, null)
		}));
	}
}
