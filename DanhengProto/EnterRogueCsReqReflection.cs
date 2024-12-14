using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000452 RID: 1106
	public static class EnterRogueCsReqReflection
	{
		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x0008775B File Offset: 0x0008595B
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterRogueCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400139F RID: 5023
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFbnRlclJvZ3VlQ3NSZXEucHJvdG8iRQoPRW50ZXJSb2d1ZUNzUmVxEg8K" + "B2FyZWFfaWQYDCABKA0SIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgP" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueCsReq), EnterRogueCsReq.Parser, new string[]
			{
				"AreaId",
				"InteractedPropEntityId"
			}, null, null, null, null)
		}));
	}
}
