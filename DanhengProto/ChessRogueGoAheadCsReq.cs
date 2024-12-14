using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200022B RID: 555
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGoAheadCsReq : IMessage<ChessRogueGoAheadCsReq>, IMessage, IEquatable<ChessRogueGoAheadCsReq>, IDeepCloneable<ChessRogueGoAheadCsReq>, IBufferMessage
	{
		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00048EA4 File Offset: 0x000470A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGoAheadCsReq> Parser
		{
			get
			{
				return ChessRogueGoAheadCsReq._parser;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x00048EAB File Offset: 0x000470AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGoAheadCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00048EBD File Offset: 0x000470BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGoAheadCsReq.Descriptor;
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00048EC4 File Offset: 0x000470C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGoAheadCsReq()
		{
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00048ECC File Offset: 0x000470CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGoAheadCsReq(ChessRogueGoAheadCsReq other) : this()
		{
			this.cellId_ = other.cellId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00048EF1 File Offset: 0x000470F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGoAheadCsReq Clone()
		{
			return new ChessRogueGoAheadCsReq(this);
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00048EF9 File Offset: 0x000470F9
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x00048F01 File Offset: 0x00047101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00048F0A File Offset: 0x0004710A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGoAheadCsReq);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00048F18 File Offset: 0x00047118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGoAheadCsReq other)
		{
			return other != null && (other == this || (this.CellId == other.CellId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00048F48 File Offset: 0x00047148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00048F87 File Offset: 0x00047187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00048F8F File Offset: 0x0004718F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00048F98 File Offset: 0x00047198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CellId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00048FCC File Offset: 0x000471CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0004900A File Offset: 0x0004720A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGoAheadCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0004903B File Offset: 0x0004723B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00049044 File Offset: 0x00047244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CellId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly MessageParser<ChessRogueGoAheadCsReq> _parser = new MessageParser<ChessRogueGoAheadCsReq>(() => new ChessRogueGoAheadCsReq());

		// Token: 0x04000AAE RID: 2734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AAF RID: 2735
		public const int CellIdFieldNumber = 13;

		// Token: 0x04000AB0 RID: 2736
		private uint cellId_;
	}
}
