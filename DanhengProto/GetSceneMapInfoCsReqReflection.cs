using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E4 RID: 2020
	public static class GetSceneMapInfoCsReqReflection
	{
		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06005A22 RID: 23074 RVA: 0x000F0555 File Offset: 0x000EE755
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSceneMapInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x040022FD RID: 8957
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRTY2VuZU1hcEluZm9Dc1JlcS5wcm90byJzChRHZXRTY2VuZU1hcElu",
			"Zm9Dc1JlcRIVCg1lbnRyeV9pZF9saXN0GA8gAygNEhsKE2VudHJ5X3N0b3J5",
			"X2xpbmVfaWQYBCABKA0SEwoLUE5GUEJJQ0dEUEMYDSABKAgSEgoKY29udGVu",
			"dF9pZBgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSceneMapInfoCsReq), GetSceneMapInfoCsReq.Parser, new string[]
			{
				"EntryIdList",
				"EntryStoryLineId",
				"PNFPBICGDPC",
				"ContentId"
			}, null, null, null, null)
		}));
	}
}
