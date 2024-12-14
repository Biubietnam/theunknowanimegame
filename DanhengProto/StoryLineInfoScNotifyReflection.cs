using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E6 RID: 4582
	public static class StoryLineInfoScNotifyReflection
	{
		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600CCC8 RID: 52424 RVA: 0x002258F8 File Offset: 0x00223AF8
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoryLineInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005291 RID: 21137
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtTdG9yeUxpbmVJbmZvU2NOb3RpZnkucHJvdG8idwoVU3RvcnlMaW5lSW5m",
			"b1NjTm90aWZ5EhwKFHRyaWFsX2F2YXRhcl9pZF9saXN0GAkgAygNEhkKEWN1",
			"cl9zdG9yeV9saW5lX2lkGAYgASgNEiUKHXVuZmluaXNoZWRfc3RvcnlfbGlu",
			"ZV9pZF9saXN0GAEgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StoryLineInfoScNotify), StoryLineInfoScNotify.Parser, new string[]
			{
				"TrialAvatarIdList",
				"CurStoryLineId",
				"UnfinishedStoryLineIdList"
			}, null, null, null, null)
		}));
	}
}
