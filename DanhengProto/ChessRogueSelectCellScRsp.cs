using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000299 RID: 665
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueSelectCellScRsp : IMessage<ChessRogueSelectCellScRsp>, IMessage, IEquatable<ChessRogueSelectCellScRsp>, IDeepCloneable<ChessRogueSelectCellScRsp>, IBufferMessage
	{
		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x00054D9B File Offset: 0x00052F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueSelectCellScRsp> Parser
		{
			get
			{
				return ChessRogueSelectCellScRsp._parser;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00054DA2 File Offset: 0x00052FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueSelectCellScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00054DB4 File Offset: 0x00052FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueSelectCellScRsp.Descriptor;
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00054DBB File Offset: 0x00052FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectCellScRsp()
		{
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00054DC4 File Offset: 0x00052FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectCellScRsp(ChessRogueSelectCellScRsp other) : this()
		{
			this.kGJJGBGFJAM_ = ((other.kGJJGBGFJAM_ != null) ? other.kGJJGBGFJAM_.Clone() : null);
			this.selectMonsterId_ = other.selectMonsterId_;
			this.cellId_ = other.cellId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00054E28 File Offset: 0x00053028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectCellScRsp Clone()
		{
			return new ChessRogueSelectCellScRsp(this);
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00054E30 File Offset: 0x00053030
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x00054E38 File Offset: 0x00053038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDMHACNANPF KGJJGBGFJAM
		{
			get
			{
				return this.kGJJGBGFJAM_;
			}
			set
			{
				this.kGJJGBGFJAM_ = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00054E41 File Offset: 0x00053041
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00054E49 File Offset: 0x00053049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectMonsterId
		{
			get
			{
				return this.selectMonsterId_;
			}
			set
			{
				this.selectMonsterId_ = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00054E52 File Offset: 0x00053052
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x00054E5A File Offset: 0x0005305A
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

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x00054E63 File Offset: 0x00053063
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00054E6B File Offset: 0x0005306B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00054E74 File Offset: 0x00053074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueSelectCellScRsp);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00054E84 File Offset: 0x00053084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueSelectCellScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.KGJJGBGFJAM, other.KGJJGBGFJAM) && this.SelectMonsterId == other.SelectMonsterId && this.CellId == other.CellId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00054EF4 File Offset: 0x000530F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kGJJGBGFJAM_ != null)
			{
				num ^= this.KGJJGBGFJAM.GetHashCode();
			}
			if (this.SelectMonsterId != 0U)
			{
				num ^= this.SelectMonsterId.GetHashCode();
			}
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00054F7B File Offset: 0x0005317B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00054F83 File Offset: 0x00053183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00054F8C File Offset: 0x0005318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.kGJJGBGFJAM_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.KGJJGBGFJAM);
			}
			if (this.CellId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CellId);
			}
			if (this.SelectMonsterId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.SelectMonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0005501C File Offset: 0x0005321C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kGJJGBGFJAM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KGJJGBGFJAM);
			}
			if (this.SelectMonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectMonsterId);
			}
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000550A4 File Offset: 0x000532A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueSelectCellScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kGJJGBGFJAM_ != null)
			{
				if (this.kGJJGBGFJAM_ == null)
				{
					this.KGJJGBGFJAM = new PDMHACNANPF();
				}
				this.KGJJGBGFJAM.MergeFrom(other.KGJJGBGFJAM);
			}
			if (other.SelectMonsterId != 0U)
			{
				this.SelectMonsterId = other.SelectMonsterId;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00055134 File Offset: 0x00053334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00055140 File Offset: 0x00053340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.kGJJGBGFJAM_ == null)
						{
							this.KGJJGBGFJAM = new PDMHACNANPF();
						}
						input.ReadMessage(this.KGJJGBGFJAM);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.CellId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SelectMonsterId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C59 RID: 3161
		private static readonly MessageParser<ChessRogueSelectCellScRsp> _parser = new MessageParser<ChessRogueSelectCellScRsp>(() => new ChessRogueSelectCellScRsp());

		// Token: 0x04000C5A RID: 3162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C5B RID: 3163
		public const int KGJJGBGFJAMFieldNumber = 7;

		// Token: 0x04000C5C RID: 3164
		private PDMHACNANPF kGJJGBGFJAM_;

		// Token: 0x04000C5D RID: 3165
		public const int SelectMonsterIdFieldNumber = 14;

		// Token: 0x04000C5E RID: 3166
		private uint selectMonsterId_;

		// Token: 0x04000C5F RID: 3167
		public const int CellIdFieldNumber = 13;

		// Token: 0x04000C60 RID: 3168
		private uint cellId_;

		// Token: 0x04000C61 RID: 3169
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000C62 RID: 3170
		private uint retcode_;
	}
}
