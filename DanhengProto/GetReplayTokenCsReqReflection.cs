using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000798 RID: 1944
	public static class GetReplayTokenCsReqReflection
	{
		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x000E8ABF File Offset: 0x000E6CBF
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetReplayTokenCsReqReflection.descriptor;
			}
		}

		// Token: 0x040021F5 RID: 8693
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlHZXRSZXBsYXlUb2tlbkNzUmVxLnByb3RvGhBSZXBsYXlUeXBlLnByb3Rv",
			"Ip0BChNHZXRSZXBsYXlUb2tlbkNzUmVxEhMKC0VIT0FPQUJFTkxBGAQgASgN",
			"EhMKC0dPSUJHTk5NSEFLGA4gASgJEhMKC0xERUFCR0xMRUVLGAMgASgNEiAK",
			"C3JlcGxheV90eXBlGA0gASgOMgsuUmVwbGF5VHlwZRIQCghzdGFnZV9pZBgH",
			"IAEoDRITCgtCTkNPT0RBSEhQQxgCIAEoCUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ReplayTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetReplayTokenCsReq), GetReplayTokenCsReq.Parser, new string[]
			{
				"EHOAOABENLA",
				"GOIBGNNMHAK",
				"LDEABGLLEEK",
				"ReplayType",
				"StageId",
				"BNCOODAHHPC"
			}, null, null, null, null)
		}));
	}
}
