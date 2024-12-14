using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200067B RID: 1659
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurSceneInfoCsReq : IMessage<GetCurSceneInfoCsReq>, IMessage, IEquatable<GetCurSceneInfoCsReq>, IDeepCloneable<GetCurSceneInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x000CA53B File Offset: 0x000C873B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurSceneInfoCsReq> Parser
		{
			get
			{
				return GetCurSceneInfoCsReq._parser;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06004A53 RID: 19027 RVA: 0x000CA542 File Offset: 0x000C8742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurSceneInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x000CA554 File Offset: 0x000C8754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurSceneInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x000CA55B File Offset: 0x000C875B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurSceneInfoCsReq()
		{
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x000CA563 File Offset: 0x000C8763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurSceneInfoCsReq(GetCurSceneInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x000CA57C File Offset: 0x000C877C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurSceneInfoCsReq Clone()
		{
			return new GetCurSceneInfoCsReq(this);
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x000CA584 File Offset: 0x000C8784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurSceneInfoCsReq);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x000CA592 File Offset: 0x000C8792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurSceneInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x000CA5B0 File Offset: 0x000C87B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x000CA5D6 File Offset: 0x000C87D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x000CA5DE File Offset: 0x000C87DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x000CA5E7 File Offset: 0x000C87E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x000CA600 File Offset: 0x000C8800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x000CA626 File Offset: 0x000C8826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurSceneInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x000CA643 File Offset: 0x000C8843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x000CA64C File Offset: 0x000C884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D82 RID: 7554
		private static readonly MessageParser<GetCurSceneInfoCsReq> _parser = new MessageParser<GetCurSceneInfoCsReq>(() => new GetCurSceneInfoCsReq());

		// Token: 0x04001D83 RID: 7555
		private UnknownFieldSet _unknownFields;
	}
}
