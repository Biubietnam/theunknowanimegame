using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012DE RID: 4830
	public static class TakeLoginActivityRewardCsReqReflection
	{
		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600D78A RID: 55178 RVA: 0x0023ED60 File Offset: 0x0023CF60
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeLoginActivityRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005605 RID: 22021
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlTG9naW5BY3Rpdml0eVJld2FyZENzUmVxLnByb3RvIj0KHFRha2VM" + "b2dpbkFjdGl2aXR5UmV3YXJkQ3NSZXESEQoJdGFrZV9kYXlzGAYgASgNEgoK" + "AmlkGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeLoginActivityRewardCsReq), TakeLoginActivityRewardCsReq.Parser, new string[]
			{
				"TakeDays",
				"Id"
			}, null, null, null, null)
		}));
	}
}
