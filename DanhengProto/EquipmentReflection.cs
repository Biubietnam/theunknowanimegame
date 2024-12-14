using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000496 RID: 1174
	public static class EquipmentReflection
	{
		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x0008F6C2 File Offset: 0x0008D8C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return EquipmentReflection.descriptor;
			}
		}

		// Token: 0x040014BB RID: 5307
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9FcXVpcG1lbnQucHJvdG8ilwEKCUVxdWlwbWVudBIMCgRyYW5rGAQgASgN",
			"EhEKCXByb21vdGlvbhgMIAEoDRILCgN0aWQYByABKA0SFwoPZHJlc3NfYXZh",
			"dGFyX2lkGAYgASgNEgsKA2V4cBgIIAEoDRIRCgl1bmlxdWVfaWQYCyABKA0S",
			"DQoFbGV2ZWwYASABKA0SFAoMaXNfcHJvdGVjdGVkGAMgASgIQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Equipment), Equipment.Parser, new string[]
			{
				"Rank",
				"Promotion",
				"Tid",
				"DressAvatarId",
				"Exp",
				"UniqueId",
				"Level",
				"IsProtected"
			}, null, null, null, null)
		}));
	}
}
