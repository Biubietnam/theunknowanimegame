using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E0 RID: 480
	public static class ChessRogueAreaInfoReflection
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0003DE4B File Offset: 0x0003C04B
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueAreaInfoReflection.descriptor;
			}
		}

		// Token: 0x04000912 RID: 2322
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhDaGVzc1JvZ3VlQXJlYUluZm8ucHJvdG8aH0NoZXNzUm9ndWVCb2FyZENl",
			"bGxTdGF0dXMucHJvdG8aEUlFS0NCQUhBREtFLnByb3RvGg5DZWxsSW5mby5w",
			"cm90bxofQ2hlc3NSb2d1ZUhpc3RvcnlDZWxsSW5mby5wcm90byL9AQoSQ2hl",
			"c3NSb2d1ZUFyZWFJbmZvEiEKGWFsbG93X3NlbGVjdF9jZWxsX2lkX2xpc3QY",
			"AiADKA0SMAoMaGlzdG9yeV9jZWxsGAYgAygLMhouQ2hlc3NSb2d1ZUhpc3Rv",
			"cnlDZWxsSW5mbxIOCgZjdXJfaWQYAyABKA0SFwoEY2VsbBgEIAEoCzIJLkNl",
			"bGxJbmZvEjAKDGxheWVyX3N0YXR1cxgLIAEoDjIaLkNoZXNzUm9ndWVCb2Fy",
			"ZENlbGxTdGF0dXMSIQoLRE9ISUJCUElLREQYCSABKAsyDC5JRUtDQkFIQURL",
			"RRIUCgxjdXJfYm9hcmRfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueBoardCellStatusReflection.Descriptor,
			IEKCBAHADKEReflection.Descriptor,
			CellInfoReflection.Descriptor,
			ChessRogueHistoryCellInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueAreaInfo), ChessRogueAreaInfo.Parser, new string[]
			{
				"AllowSelectCellIdList",
				"HistoryCell",
				"CurId",
				"Cell",
				"LayerStatus",
				"DOHIBBPIKDD",
				"CurBoardId"
			}, null, null, null, null)
		}));
	}
}
