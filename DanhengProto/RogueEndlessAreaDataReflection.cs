using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E78 RID: 3704
	public static class RogueEndlessAreaDataReflection
	{
		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x001BC27D File Offset: 0x001BA47D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueEndlessAreaDataReflection.descriptor;
			}
		}

		// Token: 0x0400437D RID: 17277
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZUVuZGxlc3NBcmVhRGF0YS5wcm90bxobUm9ndWVFbmRsZXNzTGF5",
			"ZXJJbmZvLnByb3RvGhFETlBNR0FDRUJNTS5wcm90byKJAQoUUm9ndWVFbmRs",
			"ZXNzQXJlYURhdGESEAoIcGFuZWxfaWQYByABKA0SDwoHYXJlYV9pZBgGIAEo",
			"DRIhCgtOR0VGUENFRU1FRhgFIAEoCzIMLkROUE1HQUNFQk1NEisKC0hDTUhH",
			"S0lKS0ZJGAMgASgLMhYuUm9ndWVFbmRsZXNzTGF5ZXJJbmZvQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueEndlessLayerInfoReflection.Descriptor,
			DNPMGACEBMMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueEndlessAreaData), RogueEndlessAreaData.Parser, new string[]
			{
				"PanelId",
				"AreaId",
				"NGEFPCEEMEF",
				"HCMHGKIJKFI"
			}, null, null, null, null)
		}));
	}
}
