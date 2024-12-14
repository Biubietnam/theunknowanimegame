using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000522 RID: 1314
	public static class FightActivityDataChangeScNotifyReflection
	{
		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x000A17DE File Offset: 0x0009F9DE
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightActivityDataChangeScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400179B RID: 6043
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVGaWdodEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhhGaWdo",
			"dEFjdGl2aXR5R3JvdXAucHJvdG8ixwEKH0ZpZ2h0QWN0aXZpdHlEYXRhQ2hh",
			"bmdlU2NOb3RpZnkSKAoLRFBGS1BLREtPTlAYASADKAsyEy5GaWdodEFjdGl2",
			"aXR5R3JvdXASRgoLSkROSENOSEFNTUwYDSADKAsyMS5GaWdodEFjdGl2aXR5",
			"RGF0YUNoYW5nZVNjTm90aWZ5LkpETkhDTkhBTU1MRW50cnkaMgoQSkROSENO",
			"SEFNTUxFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FightActivityGroupReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightActivityDataChangeScNotify), FightActivityDataChangeScNotify.Parser, new string[]
			{
				"DPFKPKDKONP",
				"JDNHCNHAMML"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
