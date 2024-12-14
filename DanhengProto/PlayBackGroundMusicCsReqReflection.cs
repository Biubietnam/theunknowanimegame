using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CA8 RID: 3240
	public static class PlayBackGroundMusicCsReqReflection
	{
		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x06009004 RID: 36868 RVA: 0x0017C5E4 File Offset: 0x0017A7E4
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayBackGroundMusicCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400375D RID: 14173
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5QbGF5QmFja0dyb3VuZE11c2ljQ3NSZXEucHJvdG8iMQoYUGxheUJhY2tH" + "cm91bmRNdXNpY0NzUmVxEhUKDXBsYXlfbXVzaWNfaWQYAiABKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayBackGroundMusicCsReq), PlayBackGroundMusicCsReq.Parser, new string[]
			{
				"PlayMusicId"
			}, null, null, null, null)
		}));
	}
}
