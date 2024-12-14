using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002AA RID: 682
	public static class ChessRogueUpdateAllowedSelectCellScNotifyReflection
	{
		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000577E9 File Offset: 0x000559E9
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateAllowedSelectCellScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000CBC RID: 3260
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ci9DaGVzc1JvZ3VlVXBkYXRlQWxsb3dlZFNlbGVjdENlbGxTY05vdGlmeS5w",
			"cm90byJgCilDaGVzc1JvZ3VlVXBkYXRlQWxsb3dlZFNlbGVjdENlbGxTY05v",
			"dGlmeRIhChlhbGxvd19zZWxlY3RfY2VsbF9pZF9saXN0GAYgAygNEhAKCGJv",
			"YXJkX2lkGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueUpdateAllowedSelectCellScNotify), ChessRogueUpdateAllowedSelectCellScNotify.Parser, new string[]
			{
				"AllowSelectCellIdList",
				"BoardId"
			}, null, null, null, null)
		}));
	}
}
