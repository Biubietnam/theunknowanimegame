using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B06 RID: 2822
	public static class MonopolyActionResultReflection
	{
		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x06007CED RID: 31981 RVA: 0x0014AC30 File Offset: 0x00148E30
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyActionResultReflection.descriptor;
			}
		}

		// Token: 0x04003003 RID: 12291
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpNb25vcG9seUFjdGlvblJlc3VsdC5wcm90bxoRQ0ZBT1BGR0hKSkcucHJv",
			"dG8aEUpMQkJMTkNFSlBQLnByb3RvIsABChRNb25vcG9seUFjdGlvblJlc3Vs",
			"dBITCgtDbGlja0NlbGxJZBgPIAEoDRIgCgpTb3VyY2VUeXBlGAIgASgOMgwu",
			"Q0ZBT1BGR0hKSkcSFQoNVHJpZ2dlckNlbGxJZBgIIAEoDRISCgpDbGlja01h",
			"cElkGAUgASgNEhQKDFRyaWdnZXJNYXBJZBgHIAEoDRISCgpFZmZlY3RUeXBl",
			"GAogASgNEhwKBkRldGFpbBgLIAEoCzIMLkpMQkJMTkNFSlBQQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			CFAOPFGHJJGReflection.Descriptor,
			JLBBLNCEJPPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyActionResult), MonopolyActionResult.Parser, new string[]
			{
				"ClickCellId",
				"SourceType",
				"TriggerCellId",
				"ClickMapId",
				"TriggerMapId",
				"EffectType",
				"Detail"
			}, null, null, null, null)
		}));
	}
}
