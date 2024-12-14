using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A4 RID: 1188
	public static class EvolveBuildGearDamageInfoReflection
	{
		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x000928DE File Offset: 0x00090ADE
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildGearDamageInfoReflection.descriptor;
			}
		}

		// Token: 0x0400153C RID: 5436
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Fdm9sdmVCdWlsZEdlYXJEYW1hZ2VJbmZvLnByb3RvIk8KGUV2b2x2ZUJ1" + "aWxkR2VhckRhbWFnZUluZm8SDwoHZ2Vhcl9pZBgBIAEoDRIOCgZkYW1hZ2UY" + "AiABKAESEQoJaHBfZGFtYWdlGAMgASgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildGearDamageInfo), EvolveBuildGearDamageInfo.Parser, new string[]
			{
				"GearId",
				"Damage",
				"HpDamage"
			}, null, null, null, null)
		}));
	}
}
