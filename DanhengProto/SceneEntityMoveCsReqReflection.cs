using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001064 RID: 4196
	public static class SceneEntityMoveCsReqReflection
	{
		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600BADF RID: 47839 RVA: 0x001F6985 File Offset: 0x001F4B85
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityMoveCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004BCD RID: 19405
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpTY2VuZUVudGl0eU1vdmVDc1JlcS5wcm90bxoSRW50aXR5TW90aW9uLnBy",
			"b3RvImgKFFNjZW5lRW50aXR5TW92ZUNzUmVxEhMKC1BOS05JQkxHQ0xNGAMg",
			"ASgEEikKEmVudGl0eV9tb3Rpb25fbGlzdBgPIAMoCzINLkVudGl0eU1vdGlv",
			"bhIQCghlbnRyeV9pZBgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EntityMotionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveCsReq), SceneEntityMoveCsReq.Parser, new string[]
			{
				"PNKNIBLGCLM",
				"EntityMotionList",
				"EntryId"
			}, null, null, null, null)
		}));
	}
}
