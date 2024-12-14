using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000486 RID: 1158
	public static class EntityBuffChangeInfoReflection
	{
		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x0600339B RID: 13211 RVA: 0x0008DB72 File Offset: 0x0008BD72
		public static FileDescriptor Descriptor
		{
			get
			{
				return EntityBuffChangeInfoReflection.descriptor;
			}
		}

		// Token: 0x0400147C RID: 5244
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpFbnRpdHlCdWZmQ2hhbmdlSW5mby5wcm90bxofU2NlbmVFbnRpdHlCdWZm",
			"Q2hhbmdlVHlwZS5wcm90bxoOQnVmZkluZm8ucHJvdG8ikgEKFEVudGl0eUJ1",
			"ZmZDaGFuZ2VJbmZvEhEKCWVudGl0eV9pZBgKIAEoDRIjChBidWZmX2NoYW5n",
			"ZV9pbmZvGAYgASgLMgkuQnVmZkluZm8SFgoOcmVtb3ZlX2J1ZmZfaWQYByAB",
			"KA0SKgoGcmVhc29uGAsgASgOMhouU2NlbmVFbnRpdHlCdWZmQ2hhbmdlVHlw",
			"ZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneEntityBuffChangeTypeReflection.Descriptor,
			BuffInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EntityBuffChangeInfo), EntityBuffChangeInfo.Parser, new string[]
			{
				"EntityId",
				"BuffChangeInfo",
				"RemoveBuffId",
				"Reason"
			}, null, null, null, null)
		}));
	}
}
