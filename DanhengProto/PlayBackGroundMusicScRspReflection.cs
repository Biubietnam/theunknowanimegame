using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CAA RID: 3242
	public static class PlayBackGroundMusicScRspReflection
	{
		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x06009019 RID: 36889 RVA: 0x0017C852 File Offset: 0x0017AA52
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayBackGroundMusicScRspReflection.descriptor;
			}
		}

		// Token: 0x04003762 RID: 14178
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5QbGF5QmFja0dyb3VuZE11c2ljU2NSc3AucHJvdG8iXAoYUGxheUJhY2tH" + "cm91bmRNdXNpY1NjUnNwEg8KB3JldGNvZGUYCyABKA0SGAoQY3VycmVudF9t" + "dXNpY19pZBgJIAEoDRIVCg1wbGF5X211c2ljX2lkGAQgASgNQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayBackGroundMusicScRsp), PlayBackGroundMusicScRsp.Parser, new string[]
			{
				"Retcode",
				"CurrentMusicId",
				"PlayMusicId"
			}, null, null, null, null)
		}));
	}
}
