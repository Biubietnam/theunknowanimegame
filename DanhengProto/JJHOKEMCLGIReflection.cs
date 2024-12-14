using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200096E RID: 2414
	public static class JJHOKEMCLGIReflection
	{
		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x0011F636 File Offset: 0x0011D836
		public static FileDescriptor Descriptor
		{
			get
			{
				return JJHOKEMCLGIReflection.descriptor;
			}
		}

		// Token: 0x04002942 RID: 10562
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFKSkhPS0VNQ0xHSS5wcm90bxoXUm9ndWVNYWdpY1NjZXB0ZXIucHJvdG8a",
			"Ekl0ZW1Db3N0RGF0YS5wcm90byJsCgtKSkhPS0VNQ0xHSRImCgptYWdpY19p",
			"dGVtGAMgASgLMhIuUm9ndWVNYWdpY1NjZXB0ZXISEwoLSUJQUFBDTU9BRkkY",
			"DiABKAgSIAoJY29zdF9kYXRhGA0gASgLMg0uSXRlbUNvc3REYXRhQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicScepterReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(JJHOKEMCLGI), JJHOKEMCLGI.Parser, new string[]
			{
				"MagicItem",
				"IBPPPCMOAFI",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
