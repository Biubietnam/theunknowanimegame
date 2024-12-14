using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F8 RID: 2296
	public static class HLOJFCDPGBEReflection
	{
		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06006675 RID: 26229 RVA: 0x00111C35 File Offset: 0x0010FE35
		public static FileDescriptor Descriptor
		{
			get
			{
				return HLOJFCDPGBEReflection.descriptor;
			}
		}

		// Token: 0x04002761 RID: 10081
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFITE9KRkNEUEdCRS5wcm90bxoiQWV0aGVyZGl2aWRlU3Bpcml0TGluZXVw",
			"VHlwZS5wcm90bxoPU3BCYXJJbmZvLnByb3RvImIKC0hMT0pGQ0RQR0JFEisK",
			"BHR5cGUYASABKA4yHS5BZXRoZXJkaXZpZGVTcGlyaXRMaW5ldXBUeXBlEgoK",
			"AmlkGAIgASgNEhoKBnNwX2JhchgDIAEoCzIKLlNwQmFySW5mb0IeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AetherdivideSpiritLineupTypeReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HLOJFCDPGBE), HLOJFCDPGBE.Parser, new string[]
			{
				"Type",
				"Id",
				"SpBar"
			}, null, null, null, null)
		}));
	}
}
