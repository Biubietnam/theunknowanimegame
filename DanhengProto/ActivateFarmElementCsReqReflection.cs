using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000030 RID: 48
	public static class ActivateFarmElementCsReqReflection
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00006262 File Offset: 0x00004462
		public static FileDescriptor Descriptor
		{
			get
			{
				return ActivateFarmElementCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400009D RID: 157
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5BY3RpdmF0ZUZhcm1FbGVtZW50Q3NSZXEucHJvdG8iQgoYQWN0aXZhdGVG" + "YXJtRWxlbWVudENzUmVxEhEKCWVudGl0eV9pZBgEIAEoDRITCgt3b3JsZF9s" + "ZXZlbBgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ActivateFarmElementCsReq), ActivateFarmElementCsReq.Parser, new string[]
			{
				"EntityId",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}
