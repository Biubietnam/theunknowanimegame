using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB4 RID: 4020
	public static class RogueTournFinishInfoReflection
	{
		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600B329 RID: 45865 RVA: 0x001E13F6 File Offset: 0x001DF5F6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournFinishInfoReflection.descriptor;
			}
		}

		// Token: 0x040048C1 RID: 18625
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVRvdXJuRmluaXNoSW5mby5wcm90bxoRUEZKT0dISERFQUgucHJv",
			"dG8aEExpbmV1cEluZm8ucHJvdG8aF1JvZ3VlVG91cm5DdXJJbmZvLnByb3Rv",
			"GhFQRExJTUlIQ0tGSS5wcm90bxoRS0pETEJKSEFQTUoucHJvdG8i2QEKFFJv",
			"Z3VlVG91cm5GaW5pc2hJbmZvEiEKC05GRUlJREhERU5CGA4gASgLMgwuUERM",
			"SU1JSENLRkkSJgoRcm9ndWVfbGluZXVwX2luZm8YCiABKAsyCy5MaW5ldXBJ",
			"bmZvEjAKFHJvZ3VlX3RvdXJuX2N1cl9pbmZvGAEgASgLMhIuUm9ndWVUb3Vy",
			"bkN1ckluZm8SIQoLTEFJT0tMSk5QRk8YDyABKAsyDC5LSkRMQkpIQVBNShIh",
			"CgtEUEFGQ0hNUEVKQxgMIAEoCzIMLlBGSk9HSEhERUFIQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PFJOGHHDEAHReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			RogueTournCurInfoReflection.Descriptor,
			PDLIMIHCKFIReflection.Descriptor,
			KJDLBJHAPMJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournFinishInfo), RogueTournFinishInfo.Parser, new string[]
			{
				"NFEIIDHDENB",
				"RogueLineupInfo",
				"RogueTournCurInfo",
				"LAIOKLJNPFO",
				"DPAFCHMPEJC"
			}, null, null, null, null)
		}));
	}
}
