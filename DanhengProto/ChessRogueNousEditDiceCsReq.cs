using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000251 RID: 593
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousEditDiceCsReq : IMessage<ChessRogueNousEditDiceCsReq>, IMessage, IEquatable<ChessRogueNousEditDiceCsReq>, IDeepCloneable<ChessRogueNousEditDiceCsReq>, IBufferMessage
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0004D0B1 File Offset: 0x0004B2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousEditDiceCsReq> Parser
		{
			get
			{
				return ChessRogueNousEditDiceCsReq._parser;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEditDiceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0004D0CA File Offset: 0x0004B2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousEditDiceCsReq.Descriptor;
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0004D0D1 File Offset: 0x0004B2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEditDiceCsReq()
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004D0D9 File Offset: 0x0004B2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEditDiceCsReq(ChessRogueNousEditDiceCsReq other) : this()
		{
			this.queryDiceInfo_ = ((other.queryDiceInfo_ != null) ? other.queryDiceInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0004D10E File Offset: 0x0004B30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEditDiceCsReq Clone()
		{
			return new ChessRogueNousEditDiceCsReq(this);
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0004D116 File Offset: 0x0004B316
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0004D11E File Offset: 0x0004B31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDice QueryDiceInfo
		{
			get
			{
				return this.queryDiceInfo_;
			}
			set
			{
				this.queryDiceInfo_ = value;
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0004D127 File Offset: 0x0004B327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousEditDiceCsReq);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0004D135 File Offset: 0x0004B335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousEditDiceCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.QueryDiceInfo, other.QueryDiceInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0004D168 File Offset: 0x0004B368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.queryDiceInfo_ != null)
			{
				num ^= this.QueryDiceInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0004D1A4 File Offset: 0x0004B3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0004D1AC File Offset: 0x0004B3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0004D1B5 File Offset: 0x0004B3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.queryDiceInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.QueryDiceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.queryDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryDiceInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0004D228 File Offset: 0x0004B428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousEditDiceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.queryDiceInfo_ != null)
			{
				if (this.queryDiceInfo_ == null)
				{
					this.QueryDiceInfo = new ChessRogueDice();
				}
				this.QueryDiceInfo.MergeFrom(other.QueryDiceInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0004D27C File Offset: 0x0004B47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0004D288 File Offset: 0x0004B488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.queryDiceInfo_ == null)
					{
						this.QueryDiceInfo = new ChessRogueDice();
					}
					input.ReadMessage(this.QueryDiceInfo);
				}
			}
		}

		// Token: 0x04000B48 RID: 2888
		private static readonly MessageParser<ChessRogueNousEditDiceCsReq> _parser = new MessageParser<ChessRogueNousEditDiceCsReq>(() => new ChessRogueNousEditDiceCsReq());

		// Token: 0x04000B49 RID: 2889
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B4A RID: 2890
		public const int QueryDiceInfoFieldNumber = 14;

		// Token: 0x04000B4B RID: 2891
		private ChessRogueDice queryDiceInfo_;
	}
}
