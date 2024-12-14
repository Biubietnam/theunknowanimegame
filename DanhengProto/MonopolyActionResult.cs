using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B07 RID: 2823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyActionResult : IMessage<MonopolyActionResult>, IMessage, IEquatable<MonopolyActionResult>, IDeepCloneable<MonopolyActionResult>, IBufferMessage
	{
		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x06007CEF RID: 31983 RVA: 0x0014AD13 File Offset: 0x00148F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyActionResult> Parser
		{
			get
			{
				return MonopolyActionResult._parser;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x0014AD1A File Offset: 0x00148F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyActionResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06007CF1 RID: 31985 RVA: 0x0014AD2C File Offset: 0x00148F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyActionResult.Descriptor;
			}
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x0014AD33 File Offset: 0x00148F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyActionResult()
		{
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x0014AD3C File Offset: 0x00148F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyActionResult(MonopolyActionResult other) : this()
		{
			this.clickCellId_ = other.clickCellId_;
			this.sourceType_ = other.sourceType_;
			this.triggerCellId_ = other.triggerCellId_;
			this.clickMapId_ = other.clickMapId_;
			this.triggerMapId_ = other.triggerMapId_;
			this.effectType_ = other.effectType_;
			this.detail_ = ((other.detail_ != null) ? other.detail_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x0014ADC4 File Offset: 0x00148FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyActionResult Clone()
		{
			return new MonopolyActionResult(this);
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x06007CF5 RID: 31989 RVA: 0x0014ADCC File Offset: 0x00148FCC
		// (set) Token: 0x06007CF6 RID: 31990 RVA: 0x0014ADD4 File Offset: 0x00148FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClickCellId
		{
			get
			{
				return this.clickCellId_;
			}
			set
			{
				this.clickCellId_ = value;
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x06007CF7 RID: 31991 RVA: 0x0014ADDD File Offset: 0x00148FDD
		// (set) Token: 0x06007CF8 RID: 31992 RVA: 0x0014ADE5 File Offset: 0x00148FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFAOPFGHJJG SourceType
		{
			get
			{
				return this.sourceType_;
			}
			set
			{
				this.sourceType_ = value;
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x0014ADEE File Offset: 0x00148FEE
		// (set) Token: 0x06007CFA RID: 31994 RVA: 0x0014ADF6 File Offset: 0x00148FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TriggerCellId
		{
			get
			{
				return this.triggerCellId_;
			}
			set
			{
				this.triggerCellId_ = value;
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x06007CFB RID: 31995 RVA: 0x0014ADFF File Offset: 0x00148FFF
		// (set) Token: 0x06007CFC RID: 31996 RVA: 0x0014AE07 File Offset: 0x00149007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClickMapId
		{
			get
			{
				return this.clickMapId_;
			}
			set
			{
				this.clickMapId_ = value;
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x06007CFD RID: 31997 RVA: 0x0014AE10 File Offset: 0x00149010
		// (set) Token: 0x06007CFE RID: 31998 RVA: 0x0014AE18 File Offset: 0x00149018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TriggerMapId
		{
			get
			{
				return this.triggerMapId_;
			}
			set
			{
				this.triggerMapId_ = value;
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x06007CFF RID: 31999 RVA: 0x0014AE21 File Offset: 0x00149021
		// (set) Token: 0x06007D00 RID: 32000 RVA: 0x0014AE29 File Offset: 0x00149029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EffectType
		{
			get
			{
				return this.effectType_;
			}
			set
			{
				this.effectType_ = value;
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x06007D01 RID: 32001 RVA: 0x0014AE32 File Offset: 0x00149032
		// (set) Token: 0x06007D02 RID: 32002 RVA: 0x0014AE3A File Offset: 0x0014903A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLBBLNCEJPP Detail
		{
			get
			{
				return this.detail_;
			}
			set
			{
				this.detail_ = value;
			}
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x0014AE43 File Offset: 0x00149043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyActionResult);
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x0014AE54 File Offset: 0x00149054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyActionResult other)
		{
			return other != null && (other == this || (this.ClickCellId == other.ClickCellId && this.SourceType == other.SourceType && this.TriggerCellId == other.TriggerCellId && this.ClickMapId == other.ClickMapId && this.TriggerMapId == other.TriggerMapId && this.EffectType == other.EffectType && object.Equals(this.Detail, other.Detail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x0014AEF4 File Offset: 0x001490F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClickCellId != 0U)
			{
				num ^= this.ClickCellId.GetHashCode();
			}
			if (this.SourceType != CFAOPFGHJJG.MonopolyActionResultSourceTypeNone)
			{
				num ^= this.SourceType.GetHashCode();
			}
			if (this.TriggerCellId != 0U)
			{
				num ^= this.TriggerCellId.GetHashCode();
			}
			if (this.ClickMapId != 0U)
			{
				num ^= this.ClickMapId.GetHashCode();
			}
			if (this.TriggerMapId != 0U)
			{
				num ^= this.TriggerMapId.GetHashCode();
			}
			if (this.EffectType != 0U)
			{
				num ^= this.EffectType.GetHashCode();
			}
			if (this.detail_ != null)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x0014AFCC File Offset: 0x001491CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x0014AFD4 File Offset: 0x001491D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x0014AFE0 File Offset: 0x001491E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceType != CFAOPFGHJJG.MonopolyActionResultSourceTypeNone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.SourceType);
			}
			if (this.ClickMapId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ClickMapId);
			}
			if (this.TriggerMapId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TriggerMapId);
			}
			if (this.TriggerCellId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.TriggerCellId);
			}
			if (this.EffectType != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EffectType);
			}
			if (this.detail_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Detail);
			}
			if (this.ClickCellId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ClickCellId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x0014B0C8 File Offset: 0x001492C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClickCellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClickCellId);
			}
			if (this.SourceType != CFAOPFGHJJG.MonopolyActionResultSourceTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SourceType);
			}
			if (this.TriggerCellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TriggerCellId);
			}
			if (this.ClickMapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClickMapId);
			}
			if (this.TriggerMapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TriggerMapId);
			}
			if (this.EffectType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EffectType);
			}
			if (this.detail_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Detail);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x0014B198 File Offset: 0x00149398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyActionResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClickCellId != 0U)
			{
				this.ClickCellId = other.ClickCellId;
			}
			if (other.SourceType != CFAOPFGHJJG.MonopolyActionResultSourceTypeNone)
			{
				this.SourceType = other.SourceType;
			}
			if (other.TriggerCellId != 0U)
			{
				this.TriggerCellId = other.TriggerCellId;
			}
			if (other.ClickMapId != 0U)
			{
				this.ClickMapId = other.ClickMapId;
			}
			if (other.TriggerMapId != 0U)
			{
				this.TriggerMapId = other.TriggerMapId;
			}
			if (other.EffectType != 0U)
			{
				this.EffectType = other.EffectType;
			}
			if (other.detail_ != null)
			{
				if (this.detail_ == null)
				{
					this.Detail = new JLBBLNCEJPP();
				}
				this.Detail.MergeFrom(other.Detail);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x0014B264 File Offset: 0x00149464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x0014B270 File Offset: 0x00149470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.SourceType = (CFAOPFGHJJG)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.ClickMapId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.TriggerMapId = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.TriggerCellId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EffectType = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.detail_ == null)
						{
							this.Detail = new JLBBLNCEJPP();
						}
						input.ReadMessage(this.Detail);
						continue;
					}
					if (num == 120U)
					{
						this.ClickCellId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003004 RID: 12292
		private static readonly MessageParser<MonopolyActionResult> _parser = new MessageParser<MonopolyActionResult>(() => new MonopolyActionResult());

		// Token: 0x04003005 RID: 12293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003006 RID: 12294
		public const int ClickCellIdFieldNumber = 15;

		// Token: 0x04003007 RID: 12295
		private uint clickCellId_;

		// Token: 0x04003008 RID: 12296
		public const int SourceTypeFieldNumber = 2;

		// Token: 0x04003009 RID: 12297
		private CFAOPFGHJJG sourceType_;

		// Token: 0x0400300A RID: 12298
		public const int TriggerCellIdFieldNumber = 8;

		// Token: 0x0400300B RID: 12299
		private uint triggerCellId_;

		// Token: 0x0400300C RID: 12300
		public const int ClickMapIdFieldNumber = 5;

		// Token: 0x0400300D RID: 12301
		private uint clickMapId_;

		// Token: 0x0400300E RID: 12302
		public const int TriggerMapIdFieldNumber = 7;

		// Token: 0x0400300F RID: 12303
		private uint triggerMapId_;

		// Token: 0x04003010 RID: 12304
		public const int EffectTypeFieldNumber = 10;

		// Token: 0x04003011 RID: 12305
		private uint effectType_;

		// Token: 0x04003012 RID: 12306
		public const int DetailFieldNumber = 11;

		// Token: 0x04003013 RID: 12307
		private JLBBLNCEJPP detail_;
	}
}
