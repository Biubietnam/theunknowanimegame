using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000657 RID: 1623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueBuffEnhanceInfoCsReq : IMessage<GetChessRogueBuffEnhanceInfoCsReq>, IMessage, IEquatable<GetChessRogueBuffEnhanceInfoCsReq>, IDeepCloneable<GetChessRogueBuffEnhanceInfoCsReq>, IBufferMessage
	{
		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x060048CA RID: 18634 RVA: 0x000C6E37 File Offset: 0x000C5037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueBuffEnhanceInfoCsReq> Parser
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoCsReq._parser;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x000C6E3E File Offset: 0x000C503E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x000C6E50 File Offset: 0x000C5050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x000C6E57 File Offset: 0x000C5057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueBuffEnhanceInfoCsReq()
		{
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x000C6E5F File Offset: 0x000C505F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueBuffEnhanceInfoCsReq(GetChessRogueBuffEnhanceInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x000C6E78 File Offset: 0x000C5078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueBuffEnhanceInfoCsReq Clone()
		{
			return new GetChessRogueBuffEnhanceInfoCsReq(this);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x000C6E80 File Offset: 0x000C5080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueBuffEnhanceInfoCsReq);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x000C6E8E File Offset: 0x000C508E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueBuffEnhanceInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x000C6EAC File Offset: 0x000C50AC
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

		// Token: 0x060048D3 RID: 18643 RVA: 0x000C6ED2 File Offset: 0x000C50D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x000C6EDA File Offset: 0x000C50DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x000C6EE3 File Offset: 0x000C50E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x000C6EFC File Offset: 0x000C50FC
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

		// Token: 0x060048D7 RID: 18647 RVA: 0x000C6F22 File Offset: 0x000C5122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueBuffEnhanceInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x000C6F3F File Offset: 0x000C513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x000C6F48 File Offset: 0x000C5148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D0E RID: 7438
		private static readonly MessageParser<GetChessRogueBuffEnhanceInfoCsReq> _parser = new MessageParser<GetChessRogueBuffEnhanceInfoCsReq>(() => new GetChessRogueBuffEnhanceInfoCsReq());

		// Token: 0x04001D0F RID: 7439
		private UnknownFieldSet _unknownFields;
	}
}
