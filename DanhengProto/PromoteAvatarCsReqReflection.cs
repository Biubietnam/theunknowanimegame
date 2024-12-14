using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D08 RID: 3336
	public static class PromoteAvatarCsReqReflection
	{
		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x06009502 RID: 38146 RVA: 0x0018C283 File Offset: 0x0018A483
		public static FileDescriptor Descriptor
		{
			get
			{
				return PromoteAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x040039C6 RID: 14790
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhQcm9tb3RlQXZhdGFyQ3NSZXEucHJvdG8aDkl0ZW1Db3N0LnByb3RvIkoK" + "ElByb21vdGVBdmF0YXJDc1JlcRIcCglpdGVtX2xpc3QYAiADKAsyCS5JdGVt" + "Q29zdBIWCg5iYXNlX2F2YXRhcl9pZBgNIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PromoteAvatarCsReq), PromoteAvatarCsReq.Parser, new string[]
			{
				"ItemList",
				"BaseAvatarId"
			}, null, null, null, null)
		}));
	}
}
