using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200048A RID: 1162
	public static class EntityMotionReflection
	{
		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x0008E3EA File Offset: 0x0008C5EA
		public static FileDescriptor Descriptor
		{
			get
			{
				return EntityMotionReflection.descriptor;
			}
		}

		// Token: 0x0400148F RID: 5263
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJFbnRpdHlNb3Rpb24ucHJvdG8aEE1vdGlvbkluZm8ucHJvdG8iZgoMRW50",
			"aXR5TW90aW9uEhsKBm1vdGlvbhgOIAEoCzILLk1vdGlvbkluZm8SEwoLRE9P",
			"Q0ZOUEpHTkQYCSABKAgSEQoJZW50aXR5X2lkGAwgASgNEhEKCW1hcF9sYXll",
			"chgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EntityMotion), EntityMotion.Parser, new string[]
			{
				"Motion",
				"DOOCFNPJGND",
				"EntityId",
				"MapLayer"
			}, null, null, null, null)
		}));
	}
}
