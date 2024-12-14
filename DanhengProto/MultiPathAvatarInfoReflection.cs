using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BA0 RID: 2976
	public static class MultiPathAvatarInfoReflection
	{
		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x060083C6 RID: 33734 RVA: 0x0015BE15 File Offset: 0x0015A015
		public static FileDescriptor Descriptor
		{
			get
			{
				return MultiPathAvatarInfoReflection.descriptor;
			}
		}

		// Token: 0x0400326F RID: 12911
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlNdWx0aVBhdGhBdmF0YXJJbmZvLnByb3RvGhlNdWx0aVBhdGhBdmF0YXJU",
			"eXBlLnByb3RvGhBFcXVpcFJlbGljLnByb3RvGhVBdmF0YXJTa2lsbFRyZWUu",
			"cHJvdG8ivwEKE011bHRpUGF0aEF2YXRhckluZm8SJQoQZXF1aXBfcmVsaWNf",
			"bGlzdBgJIAMoCzILLkVxdWlwUmVsaWMSLwoVbXVsdGlfcGF0aF9za2lsbF90",
			"cmVlGAwgAygLMhAuQXZhdGFyU2tpbGxUcmVlEgwKBHJhbmsYASABKA0SJwoJ",
			"YXZhdGFyX2lkGAIgASgOMhQuTXVsdGlQYXRoQXZhdGFyVHlwZRIZChFwYXRo",
			"X2VxdWlwbWVudF9pZBgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MultiPathAvatarTypeReflection.Descriptor,
			EquipRelicReflection.Descriptor,
			AvatarSkillTreeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MultiPathAvatarInfo), MultiPathAvatarInfo.Parser, new string[]
			{
				"EquipRelicList",
				"MultiPathSkillTree",
				"Rank",
				"AvatarId",
				"PathEquipmentId"
			}, null, null, null, null)
		}));
	}
}
