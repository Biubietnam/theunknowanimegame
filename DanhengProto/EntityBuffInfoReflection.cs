using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000488 RID: 1160
	public static class EntityBuffInfoReflection
	{
		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x0008E098 File Offset: 0x0008C298
		public static FileDescriptor Descriptor
		{
			get
			{
				return EntityBuffInfoReflection.descriptor;
			}
		}

		// Token: 0x04001487 RID: 5255
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRFbnRpdHlCdWZmSW5mby5wcm90bxoOQnVmZkluZm8ucHJvdG8iQQoORW50" + "aXR5QnVmZkluZm8SEQoJZW50aXR5X2lkGAEgASgNEhwKCWJ1ZmZfbGlzdBgK" + "IAMoCzIJLkJ1ZmZJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			BuffInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EntityBuffInfo), EntityBuffInfo.Parser, new string[]
			{
				"EntityId",
				"BuffList"
			}, null, null, null, null)
		}));
	}
}
