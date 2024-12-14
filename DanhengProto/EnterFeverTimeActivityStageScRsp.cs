using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000449 RID: 1097
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterFeverTimeActivityStageScRsp : IMessage<EnterFeverTimeActivityStageScRsp>, IMessage, IEquatable<EnterFeverTimeActivityStageScRsp>, IDeepCloneable<EnterFeverTimeActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x00085DEB File Offset: 0x00083FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterFeverTimeActivityStageScRsp> Parser
		{
			get
			{
				return EnterFeverTimeActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x00085DF2 File Offset: 0x00083FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterFeverTimeActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x00085E04 File Offset: 0x00084004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterFeverTimeActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00085E0B File Offset: 0x0008400B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFeverTimeActivityStageScRsp()
		{
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x00085E14 File Offset: 0x00084014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFeverTimeActivityStageScRsp(EnterFeverTimeActivityStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00085E6C File Offset: 0x0008406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFeverTimeActivityStageScRsp Clone()
		{
			return new EnterFeverTimeActivityStageScRsp(this);
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x00085E74 File Offset: 0x00084074
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x00085E7C File Offset: 0x0008407C
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

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x00085E85 File Offset: 0x00084085
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00085E8D File Offset: 0x0008408D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x00085E96 File Offset: 0x00084096
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x00085E9E File Offset: 0x0008409E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00085EA7 File Offset: 0x000840A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterFeverTimeActivityStageScRsp);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x00085EB8 File Offset: 0x000840B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterFeverTimeActivityStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x00085F18 File Offset: 0x00084118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00085F86 File Offset: 0x00084186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x00085F8E File Offset: 0x0008418E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x00085F98 File Offset: 0x00084198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00086010 File Offset: 0x00084210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00086080 File Offset: 0x00084280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterFeverTimeActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000860FC File Offset: 0x000842FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00086108 File Offset: 0x00084308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 24U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x04001364 RID: 4964
		private static readonly MessageParser<EnterFeverTimeActivityStageScRsp> _parser = new MessageParser<EnterFeverTimeActivityStageScRsp>(() => new EnterFeverTimeActivityStageScRsp());

		// Token: 0x04001365 RID: 4965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001366 RID: 4966
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001367 RID: 4967
		private uint retcode_;

		// Token: 0x04001368 RID: 4968
		public const int BattleInfoFieldNumber = 2;

		// Token: 0x04001369 RID: 4969
		private SceneBattleInfo battleInfo_;

		// Token: 0x0400136A RID: 4970
		public const int IdFieldNumber = 3;

		// Token: 0x0400136B RID: 4971
		private uint id_;
	}
}
